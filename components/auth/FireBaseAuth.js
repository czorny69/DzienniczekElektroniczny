import { getFirestore, getDoc, doc } from 'firebase/firestore'
import { app } from '../../pages/firebase-config'

export default async function Auth(login, password, set) {
  const auth = getFirestore(app)
  const docRef = doc(auth, 'administrators', login)
  const docSnap = await getDoc(docRef)
  if (docSnap.exists()) {
    const check = docSnap.data().password === password

    if (check) {
      set(true)
      return { authenticated: true, data: docSnap.data() }
    }
  }
  set(false)
  return { authenticated: false, data: {} }
}
