window.addEventListener('DOMContentLoaded', () => {
  const replaceText = (selector: any, text: string) => {
    const element = document.getElementById(selector)
    if (element) element.innerText = text
  }
})