import { FormControl} from '@angular/forms'

export function maxValue(maxInt) {
    return (control: FormControl): { [key: string]: any } => {
        if (!maxInt) return null;
        return control.value > maxInt ? { 'maxValue': maxInt } : null;
    }
}

export function minValue(minInt) {
    return (control: FormControl): { [key: string]: any } => {
        if (!minInt) minInt = 0;
        return control.value < minInt ? { 'minValue': minInt } : null;
    }
}

