const colors = require('tailwindcss/colors');
module.exports = {
  content: [
    './**/*.html',
    './**/*.razor',
      './**/*.cshtml'
  ],
  variants: {
    extend: {},
  },
  theme: {
    colors: {
      'river': {
        '50': '#f3f4f7',
        '100': '#e6e9ee',
        '200': '#c1c9d5',
        '300': '#9ca8bb',
        '400': '#516688',
        '500': '#072555',
        '600': '#06214d',
        '700': '#051c40',
        '800': '#041633',
        '900': '#03122a'
      }
    }
  },
  plugins: [],
}