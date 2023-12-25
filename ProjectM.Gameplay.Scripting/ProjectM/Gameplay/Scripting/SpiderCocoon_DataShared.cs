// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SpiderCocoon_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpiderCocoon_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsProximityActivated;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsProximityActivatedChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximityRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximityActivationTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifetimeBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivatedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivatedSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Activated;
    [FieldOffset(0)]
    public float SpawnChance;
    [FieldOffset(4)]
    public bool IsProximityActivated;
    [FieldOffset(8)]
    public float IsProximityActivatedChance;
    [FieldOffset(12)]
    public float ProximityRadius;
    [FieldOffset(16)]
    public float ProximityActivationTime;
    [FieldOffset(20)]
    public PrefabGUID LifetimeBuff;
    [FieldOffset(24)]
    public SequenceGUID ActivatedSequence;
    [FieldOffset(28)]
    public SequenceState ActivatedSequenceState;
    [FieldOffset(36)]
    public bool Activated;

    static SpiderCocoon_DataShared()
    {
      Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SpiderCocoon_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr);
      SpiderCocoon_DataShared.NativeFieldInfoPtr_SpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (SpawnChance));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_IsProximityActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (IsProximityActivated));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_IsProximityActivatedChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (IsProximityActivatedChance));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_ProximityRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (ProximityRadius));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_ProximityActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (ProximityActivationTime));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_LifetimeBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (LifetimeBuff));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_ActivatedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (ActivatedSequence));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_ActivatedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (ActivatedSequenceState));
      SpiderCocoon_DataShared.NativeFieldInfoPtr_Activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, nameof (Activated));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpiderCocoon_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
