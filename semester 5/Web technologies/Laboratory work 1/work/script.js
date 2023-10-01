function message()
{
	alert(input.value);
}
function clear()
{
	input.value = "";
}
function color(c)
{
	block.style.background = c;
}
function add()
{
	let b = document.createElement("button");
	b.innerText="Кнопка";
	list.appendChild(b);
}