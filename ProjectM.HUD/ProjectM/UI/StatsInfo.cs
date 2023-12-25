// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StatsInfo
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
  public sealed class StatsInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsList;

    static StatsInfo()
    {
      Il2CppClassPointerStore<StatsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StatsInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr);
      StatsInfo.NativeFieldInfoPtr_StatsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr, nameof (StatsList));
    }

    public StatsInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public StatsInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatsInfo>.NativeClassPtr, data));
    }

    public unsafe List<KeyValuePair_Unboxed<AssetGuid, StatInfo>> StatsList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsInfo.NativeFieldInfoPtr_StatsList));
        return pointer == System.IntPtr.Zero ? (List<KeyValuePair_Unboxed<AssetGuid, StatInfo>>) null : new List<KeyValuePair_Unboxed<AssetGuid, StatInfo>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsInfo.NativeFieldInfoPtr_StatsList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
