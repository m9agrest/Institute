
var Writes = [
	{
		name: "Михаил",
		surname: "Ермилов",
		text: "Hi",
	},
	{
		name: "Михаил",
		surname: "Ермилов",
		photo: "photo-2",
		like: 12,
	},
	{
		name: "Михаил",
		surname: "Ермилов",
		text: "Hi",
		photo: "photo",
		like: 12,
		dislike: 12,
	}
];
	
	


function Test()
{
	for(let i = 0; i < Writes.length; i++)
	{
		CreateWrite(Writes[i]);
	}
}

function CreateWrite(json)
{
	let text = "";
	let photo = "";
	let like = 0;
	let dislike = 0;
	let comment = 0;
	let icon = "none";
	let name = "None";
	let date = 0;
	
	if(json.icon != null)
	{
		icon = json.icon;
	}
	if(json.name != null)
	{
		name = json.name;
	}
	if(json.surname != null)
	{
		name += " " + json.surname;
	}
	
	if(json.text != null)
	{
		text = '<div align="left" class="write-text">' + json.text + '</div>';
	}
	if(json.photo != null)
	{
		photo = '<div class="write-image"><img class="write-image-img" src="photo/' + json.photo + '.jpg" onclick=""></div>';
	}
	if(json.like != null)
	{
		like = json.like;
	}
	if(json.dislike != null)
	{
		dislike = json.dislike;
	}
	if(json.comment != null)
	{
		comment = json.comment;
	}
	
	let block = `
				<div class="write">
					<div class="write-head">
						<img class="write-head-icon" src="photo/` + icon + `.jpg" onclick="">
						<div align="left" class="write-head-info">
							<div>
								<span class="write-head-name" onclick="">` + name + `</span>
								<span class="write-head-action">добавил запись</span>
							</div>
							<div>
								<span class="write-head-time">` + date + `</span>
							</div>
						</div>
					</div>` + text + photo + `
					<div class="write-footer">
							<div class="write-footer-block" data-id="1" data-author="1" data-type="write" onclick="SendLike(this)">
								<div class="write-footer-icon icon icon-like icon-like-action"></div>
								<div class="write-footer-text">` + like + `</div>
							</div>
							<div class="write-footer-block" data-id="1" data-author="1" data-type="write" onclick="SendDisLike(this)">
								<div class="write-footer-icon icon icon-dislike /*icon-dislike-action*/"></div>
								<div class="write-footer-text">` + dislike + `</div>
							</div>
							<div class="write-footer-block" onclick="OpenComment(this)">
								<div class="write-footer-icon icon icon-comment"></div>
								<div class="write-footer-text">` + comment + `</div>
							</div>
							<div class="write-footer-block write-footer-right" onclick="SendRepost(this)">
								<div class="write-footer-icon icon icon-repost"></div>
							</div>
					</div>
					<div class="write-comment" style="display:none">
						<img class="write-comment-icon" src="photo/none.jpg">
						<textarea class="write-comment-textarea" placeholder="Напишите комментарий..." oninput="TextareaHeight(this)"></textarea>
						
					</div>
				</div>
	`;
	
	Wall.insertAdjacentHTML('beforeend', block);
}