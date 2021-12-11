use crate::TailRec::{Return, Suspend};

fn fact(n: u32) -> u32 {
    if n == 0 {
        1
    } else {
        n * fact(n - 1)
    }
}

fn fact_tail_recursive(n: u32, acc: u32) -> u32 {
    if n == 0 {
        acc
    } else {
        fact_tail_recursive(n - 1, n * acc)
    }
}

enum TailRec<T> {
    Return(T),
    Suspend(Box<dyn FnOnce() -> TailRec<T>>),
}

impl<T> TailRec<T> {
    fn run(self) -> T {
        let mut current = self;
        loop {
            match current {
                Suspend(thunk) => current = thunk(),
                Return(value) => return value,
            }
        }
    }
}

fn fact_trampoline(n: u32, acc: u32) -> TailRec<u32> {
    if n == 0
    {
        Return(acc)
    } else {
        Suspend(Box::new(move || fact_trampoline(n - 1, n * acc)))
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_fact() {
        assert_eq!(6, fact(3))
    }

    #[test]
    fn test_fact_tramp() {
        assert_eq!(6, fact_trampoline(3, 1).run())
    }

    #[test]
    fn test_fact_tail() {
        assert_eq!(6, fact_tail_recursive(3, 1))
    }
}