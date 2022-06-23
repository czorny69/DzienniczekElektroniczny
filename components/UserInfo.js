import { useEffect, useState } from 'react'
import { Button, Input, List, Nav, toaster } from 'rsuite'
import {
  isNumeric,
  MessageData,
  MessageDataError,
  writeData
} from '../pages/mainView'

const GradeItem = ({
  grade,
  index,
  setSelectedGrade,
  setData,
  data,
  setGrades,
  selected,
  grades
}) => {
  return (
    <List.Item
      index={index}
      style={{
        display: grade.deleted ? 'none' : undefined
      }}
    >
      <div
        style={{
          width: '750px',
          display: 'flex',
          justifyContent: 'space-between',
          textAlign: 'right'
        }}
      >
        <div
          style={{
            width: '250px',
            textAlign: 'left'
          }}
        >
          {grade.subject}
        </div>
        <div
          style={{
            width: '250px',
            textAlign: 'left'
          }}
        >
          {grade.author}
        </div>
        <div
          style={{
            width: '250px',
            textAlign: 'left'
          }}
        >
          {grade.value}
        </div>
        <div
          style={{
            width: '200px',
            textAlign: 'center',
            display: 'flex',
            gap: 10
          }}
        >
          <Button
            appearance="primary"
            onClick={() => {
              setSelectedGrade({ index: index, ...grade })
            }}
          >
            Wybierz
          </Button>

          <Button
            color="red"
            appearance="primary"
            onClick={() => {
              const tempGrades = grades.filter((item, i) => i !== index)
              setGrades(tempGrades)

              const tempData = [...data]
              tempData[selected.index].grades = tempGrades
              setData(tempData)

              writeData('users/' + selected.index + '/grades/' + index, {
                ...grade,
                deleted: true,
                index: null
              })
              setSelectedGrade(undefined)
              toaster.push(MessageData, 'topCenter')
            }}
          >
            Usuń
          </Button>
        </div>
      </div>
    </List.Item>
  )
}

const UserInfo = ({ selected, data, setData, setSelected }) => {
  const [name, setName] = useState(selected.name)
  const [surname, setSurname] = useState(selected.surname)
  const [pesel, setPesel] = useState(selected.pesel)
  const [phone, setPhone] = useState(selected.phone)
  const [grades, setGrades] = useState(selected?.grades || [])
  const [active, setActive] = useState('dane')
  const [selectedGrade, setSelectedGrade] = useState(undefined)

  const [author, setAuthor] = useState('')
  const [subject, setSubject] = useState('')
  const [desc, setDesc] = useState('')
  const [value, setValue] = useState('')

  useEffect(() => {
    if (selected) {
      setName(selected.name)
      setSurname(selected.surname)
      setPesel(selected.pesel)
      setPhone(selected.phone)
      setGrades(selected?.grades || [])

      setAuthor('')
      setSubject('')
      setDesc('')
      setValue('')
    }
  }, [selected])

  useEffect(() => {
    setAuthor(selectedGrade?.author || '')
    setSubject(selectedGrade?.subject || '')
    setDesc(selectedGrade?.desc || '')
    setValue(selectedGrade?.value || '')
  }, [selectedGrade])

  return (
    <div style={{ minWidth: '500px' }}>
      <h3 style={{ marginBottom: 20 }}>Wybrany użytkownik</h3>
      <Nav activeKey={active} onSelect={setActive}>
        <Nav.Item eventKey="dane">Dane</Nav.Item>
        <Nav.Item eventKey="oceny">Oceny</Nav.Item>
      </Nav>
      {active === 'dane' && (
        <div style={{ margin: 30 }}>
          <div
            style={{
              display: 'flex',
              justifyContent: 'space-between',
              gap: 30
            }}
          >
            <div>
              <label>Imie:</label>
              <Input
                value={name}
                onChange={(value) => {
                  setName(value)
                }}
              />
            </div>
            <div>
              <label>Nazwisko:</label>
              <Input
                value={surname}
                onChange={(value) => {
                  setSurname(value)
                }}
              />
            </div>
          </div>
          <div
            style={{
              display: 'flex',
              justifyContent: 'space-between',
              marginTop: 30
            }}
          >
            <div>
              <label>Pesel:</label>
              <Input
                value={pesel}
                onChange={(value) => {
                  setPesel(value)
                }}
              />
            </div>
            <div>
              <label>Telefon:</label>
              <Input
                value={phone}
                onChange={(value) => {
                  setPhone(value)
                }}
              />
            </div>
          </div>

          <div
            style={{
              display: 'flex',
              justifyContent: 'center',
              marginTop: 30,
              gap: 30
            }}
          >
            <Button
              color="green"
              appearance="primary"
              onClick={() => {
                if (!isNumeric(phone) || !isNumeric(pesel)) {
                  toaster.push(MessageDataError, 'topCenter')
                }
                if (
                  name.length != 0 &&
                  surname.length != 0 &&
                  pesel.length != 0 &&
                  phone.length != 0 &&
                  isNumeric(phone) &&
                  isNumeric(pesel)
                ) {
                  const temp = [...data]
                  temp[selected.index].name = name
                  temp[selected.index].surname = surname
                  temp[selected.index].phone = phone
                  temp[selected.index].pesel = pesel
                  writeData('users/' + selected.index, {
                    ...temp[selected.index]
                  })
                  setData([...temp])
                  toaster.push(MessageData, 'topCenter')
                } else {
                  toaster.push(MessageDataError, 'topCenter')
                }
              }}
            >
              Zapisz
            </Button>
            <Button
              appearance="primary"
              color="red"
              onClick={() => {
                setData(data.filter((item, i) => i !== selected.index))
                writeData('users/' + selected.index, {
                  ...data[selected.index],
                  deleted: true
                })
                setSelected(undefined)
                toaster.push(MessageData, 'topCenter')
              }}
            >
              Usuń
            </Button>
          </div>
        </div>
      )}

      {active === 'oceny' && (
        <>
          <div
            style={{
              marginTop: 10
            }}
          >
            <div
              style={{
                display: 'flex',
                gap: 10,
                justifyContent: 'center',
                alignItems: 'end'
              }}
            >
              <div>
                <label>Autor:</label>
                <Input
                  value={author}
                  onChange={(value) => {
                    setAuthor(value)
                  }}
                />
              </div>
              <div>
                <label>Przedmiot:</label>
                <Input
                  value={subject}
                  onChange={(value) => {
                    setSubject(value)
                  }}
                />
              </div>
              <div>
                <label>Ocena:</label>
                <Input
                  value={value}
                  onChange={(value) => {
                    setValue(value)
                  }}
                />
              </div>
              <div>
                <Button
                  color="green"
                  appearance="primary"
                  disabled={!selectedGrade}
                  onClick={() => {
                    if (!isNumeric(value)) {
                      toaster.push(MessageDataError, 'topCenter')
                    }
                    if (
                      author.length != 0 &&
                      desc.length != 0 &&
                      subject.length != 0 &&
                      value.length != 0 &&
                      isNumeric(value)
                    ) {
                      const tempGrade = { ...selectedGrade }
                      tempGrade.author = author
                      tempGrade.desc = desc
                      tempGrade.subject = subject
                      tempGrade.value = value

                      const tempDataGrades = [...grades]
                      tempDataGrades[selectedGrade.index] = tempGrade
                      toaster.push(MessageData, 'topCenter')
                      const tempUsers = [...data]
                      tempUsers[selected.index].grades = tempDataGrades
                      setData(tempUsers)
                      setGrades(tempDataGrades)
                      writeData(
                        'users/' +
                          selected.index +
                          '/grades/' +
                          selectedGrade.index,
                        {
                          ...tempGrade,
                          index: null
                        }
                      )
                    } else {
                      toaster.push(MessageDataError, 'topCenter')
                    }
                  }}
                >
                  Zapisz
                </Button>
              </div>
            </div>
            <div>
              <div>
                <label>Opis:</label>
                <Input
                  as="textarea"
                  value={desc}
                  onChange={(value) => {
                    setDesc(value)
                  }}
                />
              </div>
            </div>
          </div>

          <List
            style={{
              marginTop: 10
            }}
          >
            <List.Item key={'columns'} index={0}>
              <div
                style={{
                  width: '750px',
                  display: 'flex',
                  justifyContent: 'space-between',
                  textAlign: 'right'
                }}
              >
                <div
                  style={{
                    width: '250px',
                    textAlign: 'left'
                  }}
                >
                  Przedmiot
                </div>
                <div
                  style={{
                    width: '250px',
                    textAlign: 'left'
                  }}
                >
                  Autor
                </div>
                <div
                  style={{
                    width: '250px',
                    textAlign: 'left'
                  }}
                >
                  Ocena
                </div>
                <div
                  style={{
                    width: '200px',
                    textAlign: 'center'
                  }}
                >
                  Akcja
                </div>
              </div>
            </List.Item>
            {grades.map((grade, index) => (
              <GradeItem
                {...{
                  grade,
                  index,
                  setSelectedGrade,
                  setData,
                  data,
                  setGrades,
                  selected,
                  grades
                }}
                key={index}
              />
            ))}
          </List>
        </>
      )}
    </div>
  )
}

export default UserInfo
