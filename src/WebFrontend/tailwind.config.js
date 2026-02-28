/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./Pages/**/*.{razor,html}",
    "./Shared/**/*.{razor,html}",
    "./Components/**/*.{razor,html}",
  ],
  theme: {
    extend: {
      colors: {
        primary: {
          DEFAULT: '#00244A',
          dark: '#001a35'
        },
        accent: '#F59B00'
      },
      fontFamily: {
        sans: ['Parkinsans', 'sans-serif']
      }
    }
  },
  plugins: [],
}
