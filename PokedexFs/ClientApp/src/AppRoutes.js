// components
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import {Home2} from "./components/home/Home2";
import { Layout } from "./components/layout/Layout";
import { PokeList} from "./components/PokeList/PokeList";

const AppRoutes = [
  {
    index: true,
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
    path: '/home2',
    element: <Layout/>
  },
  {
    path: "/fetch-data2",
    element: <PokeList />
  }
];

export default AppRoutes;
