var block = [
	{
		"image":"1",
		"text":"Райта"
	},
	{
		"image":"2",
		"text":"фармхаус"
	},
	{
		"image":"3",
		"text":"Малерхаус"
	},
	{
		"image":"4",
		"text":"Крафтсман"
	},
	{
		"image":"5",
		"text":"Фахверк"
	}
];


function load()
{
	let main = document.getElementsByTagName("main").item(0);
	for(let i = 0; i < block.length; i++)
	{
		let blockDiv = document.createElement("div");
		blockDiv.classList+="block";

		let blockSpan = document.createElement("span");
		blockSpan.innerHTML = block[i].text;
		blockDiv.appendChild(blockSpan);

		let blockImg = document.createElement("img");
		blockImg.src = "image/home/"+block[i].image+".png";
		blockDiv.appendChild(blockImg);

		main.appendChild(blockDiv);
	}
}