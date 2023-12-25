// Decompiled with JetBrains decompiler
// Type: ProjectM.RespawnCharacter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RespawnCharacter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeOfReady;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTimeToRespawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeToSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPointIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsReadyToRespawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChoiceHasBeenMade;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsRespawning;
    [FieldOffset(0)]
    public double TimeOfReady;
    [FieldOffset(8)]
    public long TimeOfDeath;
    [FieldOffset(16)]
    public float MinTimeToRespawn;
    [FieldOffset(20)]
    public float TimeToSpawn;
    [FieldOffset(24)]
    public int SpawnPointIndex;
    [FieldOffset(28)]
    public Entity FadeEntity;
    [FieldOffset(36)]
    public NetworkId SpawnLocationIcon;
    [FieldOffset(44)]
    public bool IsReadyToRespawn;
    [FieldOffset(45)]
    public bool ChoiceHasBeenMade;
    [FieldOffset(46)]
    public bool IsRespawning;

    static RespawnCharacter()
    {
      Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RespawnCharacter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr);
      RespawnCharacter.NativeFieldInfoPtr_TimeOfReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (TimeOfReady));
      RespawnCharacter.NativeFieldInfoPtr_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (TimeOfDeath));
      RespawnCharacter.NativeFieldInfoPtr_MinTimeToRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (MinTimeToRespawn));
      RespawnCharacter.NativeFieldInfoPtr_TimeToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (TimeToSpawn));
      RespawnCharacter.NativeFieldInfoPtr_SpawnPointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (SpawnPointIndex));
      RespawnCharacter.NativeFieldInfoPtr_FadeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (FadeEntity));
      RespawnCharacter.NativeFieldInfoPtr_SpawnLocationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (SpawnLocationIcon));
      RespawnCharacter.NativeFieldInfoPtr_IsReadyToRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (IsReadyToRespawn));
      RespawnCharacter.NativeFieldInfoPtr_ChoiceHasBeenMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (ChoiceHasBeenMade));
      RespawnCharacter.NativeFieldInfoPtr_IsRespawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, nameof (IsRespawning));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RespawnCharacter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
