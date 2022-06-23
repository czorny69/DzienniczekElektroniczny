import { Button, List, toaster } from 'rsuite'
import { code, MessageData, writeData } from '../pages/mainView'

const UserItem = ({ user, index, setSelected, data, setData, setAdd }) => {
  return (
    <List.Item
      index={index}
      style={{
        display: user.deleted
          ? 'none'
          : user.type === 'admin'
          ? 'none'
          : undefined
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
          {user.name}
        </div>
        <div
          style={{
            width: '250px',
            textAlign: 'left'
          }}
        >
          {user.surname}
        </div>
        <div
          style={{
            width: '200px',
            textAlign: 'left'
          }}
        >
          {user.type}
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
              setSelected({ index: index, ...user })
              setAdd(false)
            }}
          >
            Wybierz
          </Button>

          <Button
            appearance="primary"
            color="orange"
            onClick={() => {
              toaster.push(MessageData, 'topCenter')
              writeData('users/' + index, {
                ...data[index],
                password: code(data[index].pesel)
              })
            }}
          >
            Reset
          </Button>
        </div>
      </div>
    </List.Item>
  )
}

const UsersList = ({ data, setSelected, setData, setAdd, setSync, sync }) => {
  return (
    <div>
      <div
        style={{
          display: 'flex',
          justifyContent: 'space-between',
          marginBottom: 10,
          alignItems: 'end'
        }}
      >
        <h3>Lista użytkowników</h3>
        <div
          style={{
            display: 'flex',
            gap: 30
          }}
        >
          <Button
            appearance="primary"
            color="green"
            onClick={() => {
              setAdd(true)
              setSelected(undefined)
            }}
          >
            Dodaj
          </Button>
          <Button
            appearance="primary"
            color="violet"
            onClick={() => {
              setSync(!sync)
              setSelected(undefined)
              setAdd(false)
            }}
          >
            Synchronizuj
          </Button>
        </div>
      </div>

      <List>
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
              Imie
            </div>
            <div
              style={{
                width: '250px',
                textAlign: 'left'
              }}
            >
              Nazwisko
            </div>
            <div
              style={{
                width: '200px',
                textAlign: 'left'
              }}
            >
              Typ
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

        {data.map((user, index) => (
          <UserItem
            {...{ user, index, setSelected, data, setData, setAdd }}
            key={user?.pesel + index}
          />
        ))}
      </List>
    </div>
  )
}

export default UsersList
