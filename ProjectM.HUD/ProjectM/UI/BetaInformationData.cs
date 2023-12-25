// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BetaInformationData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class BetaInformationData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Width;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountDownToTimeUTC;

    static BetaInformationData()
    {
      Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BetaInformationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr);
      BetaInformationData.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, nameof (Width));
      BetaInformationData.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, nameof (Header));
      BetaInformationData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, nameof (Text));
      BetaInformationData.NativeFieldInfoPtr_CountDownToTimeUTC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, nameof (CountDownToTimeUTC));
    }

    public BetaInformationData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BetaInformationData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BetaInformationData>.NativeClassPtr, data));
    }

    public unsafe float Width
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Width));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Width)) = value;
      }
    }

    public unsafe string Header
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Header)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Header), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string CountDownToTimeUTC
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_CountDownToTimeUTC)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationData.NativeFieldInfoPtr_CountDownToTimeUTC), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
