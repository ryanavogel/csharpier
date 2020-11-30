import { concat, join } from "./Builders";
import { getValue, HasModifiers } from "./SyntaxTreeNode";

export function printModifiers(node: HasModifiers) {
    if (node.modifiers.length === 0) {
        return "";
    }
    return concat([join(" ", node.modifiers.map(o => getValue(o))), " "]);
}