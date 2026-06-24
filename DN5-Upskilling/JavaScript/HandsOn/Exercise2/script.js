function validate() {
  let e = document.getElementById('email').value;
  if(e.includes('@')) document.getElementById('msg').innerText = 'Valid';
  else document.getElementById('msg').innerText = 'Invalid';
}
