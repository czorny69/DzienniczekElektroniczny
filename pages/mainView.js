import { child, get, getDatabase, ref, set } from 'firebase/database'
import { useEffect, useState } from 'react'
import { Message, Panel } from 'rsuite'
import UsersList from '../components/List'
import UserAdd from '../components/UserAdd'
import UserInfo from '../components/UserInfo'
import { app } from './firebase-config'

export async function getData(set) {
  const dbRef = ref(getDatabase(app))

  get(child(dbRef, `/users`))
    .then((snapshot) => {
      if (snapshot.exists()) {
        set(snapshot.val())
      } else {
        console.log('No data available')
      }
    })
    .catch((error) => {
      console.error(error)
    })
}

export const MessageData = (
  <Message showIcon type={'success'}>
    Operacja udana!
  </Message>
)

export const MessageDataError = (
  <Message showIcon type={'error'}>
    Nieprawidłowe dane!
  </Message>
)

export function decode(data) {
  return Buffer.from(data, 'base64').toString('ascii')
}

export function code(data) {
  return Buffer.from(data).toString('base64')
}

export function writeData(path, data) {
  const db = getDatabase(app)
  set(ref(db, path), { ...data })
}

export function isNumeric(str) {
  if (typeof str != 'string') return false
  return !isNaN(str) && !isNaN(parseFloat(str))
}

const MainView = (authenticated) => {
  const [data, setData] = useState([])
  const [sync, setSync] = useState(false)
  const [add, setAdd] = useState(false)
  const [selected, setSelected] = useState(undefined)

  useEffect(() => {
    if (authenticated) getData(setData)
  }, [sync])

  return (
    <div
      style={{
        display: 'flex',
        flexDirection: 'row',
        justifyContent: 'space-evenly',
        width: '100%',
        height: '100%',
        margin: 100
      }}
    >
      <Panel shaded bordered style={{ minHeight: '600px' }}>
        <UsersList {...{ data, setSelected, setData, setAdd, setSync, sync }} />
      </Panel>

      {selected && (
        <Panel shaded bordered style={{ minHeight: '600px' }}>
          <UserInfo {...{ selected, data, setData, setSelected }} />
        </Panel>
      )}

      {add && (
        <Panel shaded bordered style={{ minHeight: '600px' }}>
          <UserAdd {...{ data, setData, setSelected, setAdd }} />
        </Panel>
      )}
    </div>
  )
}

export default MainView
