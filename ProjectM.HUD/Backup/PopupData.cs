// Decompiled with JetBrains decompiler
// Type: PopupData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public sealed class PopupData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_PopupNode;

  static PopupData()
  {
    Il2CppClassPointerStore<PopupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (PopupData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupData>.NativeClassPtr);
    PopupData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupData>.NativeClassPtr, nameof (Type));
    PopupData.NativeFieldInfoPtr_PopupNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupData>.NativeClassPtr, nameof (PopupNode));
  }

  public PopupData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PopupData()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PopupData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PopupData>.NativeClassPtr, data));
  }

  public unsafe PopupType Type
  {
    get
    {
      return *(PopupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupData.NativeFieldInfoPtr_Type));
    }
    [param: In] set
    {
      *(PopupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupData.NativeFieldInfoPtr_Type)) = value;
    }
  }

  public unsafe PopupBase PopupNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupData.NativeFieldInfoPtr_PopupNode));
      return pointer == System.IntPtr.Zero ? (PopupBase) null : new PopupBase(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopupData.NativeFieldInfoPtr_PopupNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
