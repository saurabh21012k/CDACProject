import axios from 'axios';

export default axios.create({
  // baseURL: 'http://localhost:8080/FarmersMarketplace/',
  baseURL: 'https://localhost:7213/',

  headers: {
   
    'Content-Type': 'application/json',
  },
  
});
