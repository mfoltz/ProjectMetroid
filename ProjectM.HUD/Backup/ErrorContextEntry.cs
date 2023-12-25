// Decompiled with JetBrains decompiler
// Type: ErrorContextEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;

#nullable disable
public class ErrorContextEntry : UIEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ErrorText;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205924, RefRangeEnd = 1205925, XrefRangeStart = 1205920, XrefRangeEnd = 1205924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(ErrorContextEntry.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorContextEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ErrorContextEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorContextEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ErrorContextEntry()
  {
    Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ErrorContextEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr);
    ErrorContextEntry.NativeFieldInfoPtr_ErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr, nameof (ErrorText));
    ErrorContextEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr, 100663360);
    ErrorContextEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr, 100663361);
  }

  public ErrorContextEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText ErrorText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorContextEntry.NativeFieldInfoPtr_ErrorText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ErrorContextEntry.NativeFieldInfoPtr_ErrorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorText;

    static Data()
    {
      Il2CppClassPointerStore<ErrorContextEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ErrorContextEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorContextEntry.Data>.NativeClassPtr);
      ErrorContextEntry.Data.NativeFieldInfoPtr_ErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContextEntry.Data>.NativeClassPtr, nameof (ErrorText));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorContextEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorContextEntry.Data>.NativeClassPtr, data));
    }

    public unsafe string ErrorText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorContextEntry.Data.NativeFieldInfoPtr_ErrorText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ErrorContextEntry.Data.NativeFieldInfoPtr_ErrorText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
