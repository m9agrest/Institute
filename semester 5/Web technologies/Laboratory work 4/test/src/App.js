import React, {useState} from 'react';
import {TestData} from './TestData.js';

const NewsList = ({newsList = [], setSelect}) => {
	/*const handleClick = (news) => {
		setSelect(news);
	}*/
	const makeList = () => {
		return newsList.map( (news) => {
			/*return <div key={news.id} className="news__item">
				<p onClick={() => {handleClick(news)}}>{news.title}</p>
			</div>;*/
			return <div key={news.id} className="news__item">
				<p onClick={() => {setSelect(news)}}>{news.title}</p>
			</div>;
		});
	}
	return <div className="news__list">
		{makeList()}
	</div>;
}

const DetailNews = ({news}) => {
	if(!news)
		return <></>;
	
	return <div className="news__detail">
		<h1>{news.title}</h1>
		<span>{news.text}</span>
	</div>;
}

function App() {
	const [news, setNews] = useState(TestData);
	const [selectNews, setSelectNews] = useState(false);
	return <>
		{selectNews &&
			<button onClick={()=>{setSelectNews(false)}}>К списку</button>
		}
		{selectNews && news.length > 0
			? <div>
				<DetailNews news={selectNews} />
			</div>
			: <div className="news">
				<NewsList newsList={news} setSelect={setSelectNews} />
			</div>
		}
	</>
	/*return <>
		<div className="news">
			<NewsList newsList={news} setSelect={setSelectNews} />
		</div>
		<div>
			<DetailNews news={selectNews} />
		</div>
	</>;*/
}

export default App;

/*
export default App() {
	return <div><div>;
}
*/