using System;
public class BillingService
{
    public static PatientBill LastBill;
    public static bool HasLastBill = false;

    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();
        if (string.IsNullOrEmpty(bill.BillId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }
p
        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        char ch=Convert.ToChar(Console.ReadLine());
        ch=Char.ToLower(ch);
        bool hasInsurance=ch=='y'?true:false;

        // Console.Write("Is the patient insured? (Y/N): ");
        // string insuranceInput = Console.ReadLine();
        // bill.HasInsurance = insuranceInput.Equals("Y", StringComparison.OrdinalIgnoreCase);


        Console.Write("Enter Consultation Fee: ");
        bill.ConsultationFee = Convert.ToDecimal(Console.ReadLine());
        if (bill.ConsultationFee <= 0)
        {
            Console.WriteLine("Consultation Fee must be greater than zero.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        bill.LabCharges = Convert.ToDecimal(Console.ReadLine());
        if (bill.LabCharges < 0)
        {
            Console.WriteLine("Lab Charges cannot be negative.");
            return;
        }

        Console.Write("Enter Medicine Charges: ");
        bill.MedicineCharges = Convert.ToDecimal(Console.ReadLine());
        if (bill.MedicineCharges < 0)
        {
            Console.WriteLine("Medicine Charges cannot be negative.");
            return;
        }

        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance)
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        else
            bill.DiscountAmount = 0;

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine("Gross Amount: " + bill.GrossAmount.ToString("0.00"));
        Console.WriteLine("Discount Amount: " + bill.DiscountAmount.ToString("0.00"));
        Console.WriteLine("Final Payable: " + bill.FinalPayable.ToString("0.00"));
        Console.WriteLine("------------------------------------------------------------");
    }

    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine("BillId: " + LastBill.BillId);
        Console.WriteLine("Patient: " + LastBill.PatientName);
        Console.WriteLine("Insured: " + (LastBill.HasInsurance ? "Yes" : "No"));
        Console.WriteLine("Consultation Fee: " + LastBill.ConsultationFee.ToString("0.00"));
        Console.WriteLine("Lab Charges: " + LastBill.LabCharges.ToString("0.00"));
        Console.WriteLine("Medicine Charges: " + LastBill.MedicineCharges.ToString("0.00"));
        Console.WriteLine("Gross Amount: " + LastBill.GrossAmount.ToString("0.00"));
        Console.WriteLine("Discount Amount: " + LastBill.DiscountAmount.ToString("0.00"));
        Console.WriteLine("Final Payable: " + LastBill.FinalPayable.ToString("0.00"));
        Console.WriteLine("--------------------------------");
        Console.WriteLine("------------------------------------------------------------");
    }

    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}
