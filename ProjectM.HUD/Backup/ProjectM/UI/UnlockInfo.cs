// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UnlockInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class UnlockInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockInfoList;

    static UnlockInfo()
    {
      Il2CppClassPointerStore<UnlockInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UnlockInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockInfo>.NativeClassPtr);
      UnlockInfo.NativeFieldInfoPtr_UnlockInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockInfo>.NativeClassPtr, nameof (UnlockInfoList));
    }

    public UnlockInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public UnlockInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnlockInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockInfo>.NativeClassPtr, data));
    }

    public unsafe List<AssetGuid> UnlockInfoList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockInfo.NativeFieldInfoPtr_UnlockInfoList));
        return pointer == System.IntPtr.Zero ? (List<AssetGuid>) null : new List<AssetGuid>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockInfo.NativeFieldInfoPtr_UnlockInfoList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
