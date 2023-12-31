// Decompiled with JetBrains decompiler
// Type: ProjectM.StationBonusData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StationBonusData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirement;
    [FieldOffset(0)]
    public float ModificationValue;
    [FieldOffset(4)]
    public PrefabGUID Guid;
    [FieldOffset(8)]
    public Entity Entity;
    [FieldOffset(16)]
    public StationBonusType BonusType;
    [FieldOffset(20)]
    public StationBonusRequirement Requirement;

    static StationBonusData()
    {
      Il2CppClassPointerStore<StationBonusData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StationBonusData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr);
      StationBonusData.NativeFieldInfoPtr_ModificationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, nameof (ModificationValue));
      StationBonusData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, nameof (Guid));
      StationBonusData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, nameof (Entity));
      StationBonusData.NativeFieldInfoPtr_BonusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, nameof (BonusType));
      StationBonusData.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, nameof (Requirement));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StationBonusData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
