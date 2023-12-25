// Decompiled with JetBrains decompiler
// Type: ProjectM.MissionData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MissionData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionDifficulty;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysUnlocked;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(4)]
    public int MissionDifficulty;
    [FieldOffset(8)]
    public int ServantSlots;
    [FieldOffset(12)]
    public bool AlwaysUnlocked;

    static MissionData()
    {
      Il2CppClassPointerStore<MissionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MissionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionData>.NativeClassPtr);
      MissionData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, nameof (PrefabGUID));
      MissionData.NativeFieldInfoPtr_MissionDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, nameof (MissionDifficulty));
      MissionData.NativeFieldInfoPtr_ServantSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, nameof (ServantSlots));
      MissionData.NativeFieldInfoPtr_AlwaysUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionData>.NativeClassPtr, nameof (AlwaysUnlocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MissionData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
