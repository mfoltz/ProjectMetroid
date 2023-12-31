// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.GameplayLocationInfo
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayLocationInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CasterPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Targets;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraDistanceAllowed;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnsureGroundedPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionInfo;
    [FieldOffset(0)]
    public float3 CasterPosition;
    [FieldOffset(12)]
    public FixedList64<float3> Targets;
    [FieldOffset(76)]
    public float ExtraDistanceAllowed;
    [FieldOffset(80)]
    public bool EnsureGroundedPosition;
    [FieldOffset(84)]
    public GameplayLocationCollisionInfo CollisionInfo;

    static GameplayLocationInfo()
    {
      Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay", nameof (GameplayLocationInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr);
      GameplayLocationInfo.NativeFieldInfoPtr_CasterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, nameof (CasterPosition));
      GameplayLocationInfo.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, nameof (Targets));
      GameplayLocationInfo.NativeFieldInfoPtr_ExtraDistanceAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, nameof (ExtraDistanceAllowed));
      GameplayLocationInfo.NativeFieldInfoPtr_EnsureGroundedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, nameof (EnsureGroundedPosition));
      GameplayLocationInfo.NativeFieldInfoPtr_CollisionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, nameof (CollisionInfo));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayLocationInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
