// components
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import {Home2} from "./components/home/Home2";
import { Layout } from "./components/layout/Layout";
import { PokeList } from "./components/PokeList/PokeList";

const AppRoutes = [
  {
    path: '/',
    element: <Layout/>
  },
  {
    path: "/home",
    element: <Home2 />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: "/fetch-data2",
    element: <PokeList />
  }
];

export default AppRoutes;
