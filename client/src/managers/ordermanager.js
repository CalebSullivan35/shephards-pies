const _apiUrl = "/api/Order";

export const getOrders = () => {
 return fetch(_apiUrl).then((res) => res.json());
};

export const getOrderDetails = (id) => {
 return fetch(`${_apiUrl}/${id}`).then((res) => res.json());
};

export const postOrder = (order) => {
 return fetch(_apiUrl, {
  method: "POST",
  headers: {
   "Content-Type": "application/json",
  },
  body: JSON.stringify(order),
 }).then((res) => res.json());
};

export const deleteOrder = (order) => {
 return fetch(`${_apiUrl}/${order.id}`, {
  method: "DELETE",
 });
};
