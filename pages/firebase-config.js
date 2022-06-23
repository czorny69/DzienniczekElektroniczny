// Import the functions you need from the SDKs you need
import { initializeApp } from 'firebase/app'

// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: 'AIzaSyBpEekW4DEBwkBI9EfHAhCJQxofztpc52I',
  authDomain: 'dzienniczek-92d18.firebaseapp.com',
  databaseURL:
    'https://dzienniczek-92d18-default-rtdb.europe-west1.firebasedatabase.app',
  projectId: 'dzienniczek-92d18',
  storageBucket: 'dzienniczek-92d18.appspot.com',
  messagingSenderId: '1094102912309',
  appId: '1:1094102912309:web:2923a786d3e9e196ead07c',
  measurementId: 'G-R3LGC74NGH'
}

// Initialize Firebase
export const app = initializeApp(firebaseConfig)
