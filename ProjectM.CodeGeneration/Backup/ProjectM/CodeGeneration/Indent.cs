// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.Indent
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Indent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_None;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Spaces;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalSpaces_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Indent_Indent_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Indent_Indent_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyIndentOnRow_Public_Void_StringBuilder_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IndentText_Public_String_String_0;
    [FieldOffset(0)]
    public int Tabs;
    [FieldOffset(4)]
    public int Spaces;

    public unsafe int TotalSpaces
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_get_TotalSpaces_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Indent(int tabs, int spaces)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spaces;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe Indent operator +(Indent a, Indent b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_op_Addition_Public_Static_Indent_Indent_Indent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Indent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe Indent operator -(Indent a, Indent b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_op_Subtraction_Public_Static_Indent_Indent_Indent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Indent*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635481, XrefRangeEnd = 635485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635485, XrefRangeEnd = 635488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyIndentOnRow(StringBuilder sb, string row)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(row);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_ApplyIndentOnRow_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 635512, RefRangeEnd = 635517, XrefRangeStart = 635488, XrefRangeEnd = 635512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string IndentText(string baseText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Indent.NativeMethodInfoPtr_IndentText_Public_String_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Indent()
    {
      Il2CppClassPointerStore<Indent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (Indent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Indent>.NativeClassPtr);
      Indent.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Indent>.NativeClassPtr, nameof (None));
      Indent.NativeFieldInfoPtr_Tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Indent>.NativeClassPtr, nameof (Tabs));
      Indent.NativeFieldInfoPtr_Spaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Indent>.NativeClassPtr, nameof (Spaces));
      Indent.NativeMethodInfoPtr_get_TotalSpaces_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663474);
      Indent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663475);
      Indent.NativeMethodInfoPtr_op_Addition_Public_Static_Indent_Indent_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663476);
      Indent.NativeMethodInfoPtr_op_Subtraction_Public_Static_Indent_Indent_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663477);
      Indent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663478);
      Indent.NativeMethodInfoPtr_ApplyIndentOnRow_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663479);
      Indent.NativeMethodInfoPtr_IndentText_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Indent>.NativeClassPtr, 100663480);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Indent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe Indent None
    {
      get
      {
        Indent none;
        IL2CPP.il2cpp_field_static_get_value(Indent.NativeFieldInfoPtr_None, (void*) &none);
        return none;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Indent.NativeFieldInfoPtr_None, (void*) &value);
      }
    }
  }
}
