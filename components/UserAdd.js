import { useState } from 'react'
import { Button, Input, SelectPicker, toaster } from 'rsuite'
import {
  code,
  isNumeric,
  MessageData,
  MessageDataError,
  writeData
} from '../pages/mainView'

const pickerData = [
  {
    label: 'admin',
    value: 'admin'
  },
  {
    label: 'teacher',
    value: 'teacher'
  },
  {
    label: 'student',
    value: 'student'
  }
]

const UserAdd = ({ data, setData }) => {
  const [name, setName] = useState('')
  const [surname, setSurname] = useState('')
  const [pesel, setPesel] = useState('')
  const [phone, setPhone] = useState('')
  const [type, setType] = useState('')

  return (
    <div>
      <h3>Dodawanie użytkownika</h3>
      <div
        style={{
          marginBottom: 10
        }}
      >
        <div
          style={{
            display: 'flex',
            justifyContent: 'space-between',
            marginTop: 20,
            alignItems: 'end',
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
            marginTop: 20,
            alignItems: 'end',
            gap: 30
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
                setPhone(value || undefined)
              }}
            />
          </div>
        </div>
        <div
          style={{
            display: 'flex',
            justifyContent: 'space-between',
            marginTop: 20,
            alignItems: 'end',
            gap: 30
          }}
        >
          <div
            style={{
              display: 'flex',
              flexDirection: 'column'
            }}
          >
            <label>Typ:</label>
            <SelectPicker
              searchable={false}
              data={pickerData}
              value={type}
              onChange={(value) => {
                setType(value || null)
              }}
            />
          </div>
          <div>
            <Button
              appearance="primary"
              color="green"
              onClick={() => {
                if (!isNumeric(phone) || !isNumeric(pesel)) {
                  toaster.push(MessageDataError, 'topCenter')
                }
                if (
                  name.length != 0 &&
                  surname.length != 0 &&
                  // type.length != 0 &&
                  pesel.length != 0 &&
                  phone.length != 0 &&
                  type != null &&
                  isNumeric(phone) &&
                  isNumeric(pesel)
                ) {
                  writeData('users/' + data.length, {
                    name: name,
                    surname: surname,
                    type: type,
                    pesel: pesel,
                    phone: phone,
                    password: code(pesel),
                    deleted: false
                  })

                  setData([
                    ...data,
                    {
                      name: name,
                      surname: surname,
                      type: type,
                      pesel: pesel,
                      phone: phone,
                      password: code(pesel),
                      deleted: false
                    }
                  ])
                  toaster.push(MessageData, 'topCenter')
                  setName('')
                  setSurname('')
                  setPesel('')
                  setPhone('')
                  setType('')
                }
              }}
            >
              Dodaj
            </Button>
          </div>
        </div>
      </div>
    </div>
  )
}

export default UserAdd
