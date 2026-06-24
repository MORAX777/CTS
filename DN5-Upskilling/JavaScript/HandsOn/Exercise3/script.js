let count = 0;
setInterval(() => {
  count++;
  document.getElementById('timer').innerText = count;
}, 1000);
