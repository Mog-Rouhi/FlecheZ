import {
  Avatar,
  Button,
  List,
  ListItem,
  ListItemAvatar,
  ListItemText,
} from "@mui/material";
import { Product } from "../../app/models/product";

interface Props {
  products: Product[];
  addProduct: () => void;
}

export default function Catalog({ products, addProduct }: Props) {
  return (
    <>
      <List>
        <Button variant="contained" onClick={addProduct}>
          Add Product
        </Button>

        {products.map((item, index) => (
          <ListItem key={index}>
            <ListItemAvatar>
              <Avatar src={item.pictureUrl} />
            </ListItemAvatar>
            <ListItemText>
              {item.name} - {item.price}
            </ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  );
}
