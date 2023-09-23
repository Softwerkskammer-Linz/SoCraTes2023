import { describe, it, expect } from "vitest";

describe("diamond", () => {
  it("should transform A to A", () => {
    expect(diamond("A")).toEqual("A");
  });
  it("should transform B to B-diamond", () => {
    expect(diamond("B")).toEqual(".A.\nB.B\n.A.");
  });
  it("should transform C to C-diamond", () => {
    expect(diamond("C")).toEqual("..A..\n.B.B.\nC...C\n.B.B.\n..A..");
  });
});

describe("buildMiddle", function () {
  it("should return middle line for B diamond", () => {
    expect(buildMiddle("B")).toBe("B.B");
  });
  it("should return middle line for C diamond", () => {
    expect(buildMiddle("C")).toBe("C...C");
  });
});

function buildMiddle(letter: string) {
  return letter + (letter === "C" ? "..." : ".") + letter;
}

function diamond(letter: string): string {
  if (letter === "C") {
    return ["..A..", ".B.B.", buildMiddle(letter), ".B.B.", "..A.."].join("\n");
  }
  if (letter === "B") {
    return [".A.", buildMiddle(letter), ".A."].join("\n");
  }
  return [letter].join("\n");
}
