// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnerstation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitSpawnerstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpawnedUnits;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRadiusMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRadiusMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDestroyAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWorking;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    [FieldOffset(0)]
    public int MaxSpawnedUnits;
    [FieldOffset(4)]
    public float SpawnRadiusMin;
    [FieldOffset(8)]
    public float SpawnRadiusMax;
    [FieldOffset(12)]
    public UnitSpawnerOnDestroyAction OnDestroyAction;
    [FieldOffset(16)]
    public PrefabGUID CurrentRecipeGuid;
    [FieldOffset(20)]
    public float Progress;
    [FieldOffset(24)]
    public bool IsWorking;
    [FieldOffset(28)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(32)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(40)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(44)]
    public SequenceState InactiveSequenceState;

    static UnitSpawnerstation()
    {
      Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitSpawnerstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr);
      UnitSpawnerstation.NativeFieldInfoPtr_MaxSpawnedUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (MaxSpawnedUnits));
      UnitSpawnerstation.NativeFieldInfoPtr_SpawnRadiusMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (SpawnRadiusMin));
      UnitSpawnerstation.NativeFieldInfoPtr_SpawnRadiusMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (SpawnRadiusMax));
      UnitSpawnerstation.NativeFieldInfoPtr_OnDestroyAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (OnDestroyAction));
      UnitSpawnerstation.NativeFieldInfoPtr_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (CurrentRecipeGuid));
      UnitSpawnerstation.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (Progress));
      UnitSpawnerstation.NativeFieldInfoPtr_IsWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (IsWorking));
      UnitSpawnerstation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      UnitSpawnerstation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (ActiveSequenceState));
      UnitSpawnerstation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      UnitSpawnerstation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, nameof (InactiveSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnerstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
