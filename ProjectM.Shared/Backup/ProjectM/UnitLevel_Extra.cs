// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitLevel_Extra
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitLevel_Extra
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthUnitBaseStatsType;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
    [FieldOffset(0)]
    public UnitBaseStatsType HealthUnitBaseStatsType;
    [FieldOffset(1)]
    public UnitBaseStatsType UnitBaseStatsType;

    static UnitLevel_Extra()
    {
      Il2CppClassPointerStore<UnitLevel_Extra>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitLevel_Extra));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitLevel_Extra>.NativeClassPtr);
      UnitLevel_Extra.NativeFieldInfoPtr_HealthUnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevel_Extra>.NativeClassPtr, nameof (HealthUnitBaseStatsType));
      UnitLevel_Extra.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevel_Extra>.NativeClassPtr, nameof (UnitBaseStatsType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitLevel_Extra>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
