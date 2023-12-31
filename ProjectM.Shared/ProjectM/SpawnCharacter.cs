// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnCharacter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnCharacter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_User;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomSpawnLocation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomSpawnLocation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnLocationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstTimeSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstTimeSpawnBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostSpawn_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostSpawn_Coffin;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitingForContentHideBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasDoneFirstSpawnAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Customization;
    private static readonly System.IntPtr NativeFieldInfoPtr_CoffinEntity;
    [FieldOffset(0)]
    public Entity User;
    [FieldOffset(8)]
    public Entity CharacterPrefab;
    [FieldOffset(16)]
    public bool UseCustomSpawnLocation;
    [FieldOffset(20)]
    public float3 CustomSpawnLocation;
    [FieldOffset(32)]
    public int SpawnLocationIndex;
    [FieldOffset(36)]
    public bool FirstTimeSpawn;
    [FieldOffset(40)]
    public Entity FirstTimeSpawnBuff;
    [FieldOffset(48)]
    public PrefabGUID PvPProtectionBuff;
    [FieldOffset(52)]
    public Entity PreviousCharacter;
    [FieldOffset(60)]
    public Entity FadeOutEntity;
    [FieldOffset(68)]
    public bool HasSpawned;
    [FieldOffset(72)]
    public int FrameSpawned;
    [FieldOffset(80)]
    public double TimeSpawned;
    [FieldOffset(88)]
    public Entity PostSpawn_Character;
    [FieldOffset(96)]
    public Entity PostSpawn_Coffin;
    [FieldOffset(104)]
    public Entity WaitingForContentHideBuff;
    [FieldOffset(112)]
    public bool HasDoneFirstSpawnAction;
    [FieldOffset(113)]
    public CustomizationFeatures Customization;
    [FieldOffset(124)]
    public Entity CoffinEntity;

    static SpawnCharacter()
    {
      Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnCharacter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr);
      SpawnCharacter.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (User));
      SpawnCharacter.NativeFieldInfoPtr_CharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (CharacterPrefab));
      SpawnCharacter.NativeFieldInfoPtr_UseCustomSpawnLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (UseCustomSpawnLocation));
      SpawnCharacter.NativeFieldInfoPtr_CustomSpawnLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (CustomSpawnLocation));
      SpawnCharacter.NativeFieldInfoPtr_SpawnLocationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (SpawnLocationIndex));
      SpawnCharacter.NativeFieldInfoPtr_FirstTimeSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (FirstTimeSpawn));
      SpawnCharacter.NativeFieldInfoPtr_FirstTimeSpawnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (FirstTimeSpawnBuff));
      SpawnCharacter.NativeFieldInfoPtr_PvPProtectionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (PvPProtectionBuff));
      SpawnCharacter.NativeFieldInfoPtr_PreviousCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (PreviousCharacter));
      SpawnCharacter.NativeFieldInfoPtr_FadeOutEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (FadeOutEntity));
      SpawnCharacter.NativeFieldInfoPtr_HasSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (HasSpawned));
      SpawnCharacter.NativeFieldInfoPtr_FrameSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (FrameSpawned));
      SpawnCharacter.NativeFieldInfoPtr_TimeSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (TimeSpawned));
      SpawnCharacter.NativeFieldInfoPtr_PostSpawn_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (PostSpawn_Character));
      SpawnCharacter.NativeFieldInfoPtr_PostSpawn_Coffin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (PostSpawn_Coffin));
      SpawnCharacter.NativeFieldInfoPtr_WaitingForContentHideBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (WaitingForContentHideBuff));
      SpawnCharacter.NativeFieldInfoPtr_HasDoneFirstSpawnAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (HasDoneFirstSpawnAction));
      SpawnCharacter.NativeFieldInfoPtr_Customization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (Customization));
      SpawnCharacter.NativeFieldInfoPtr_CoffinEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, nameof (CoffinEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnCharacter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
