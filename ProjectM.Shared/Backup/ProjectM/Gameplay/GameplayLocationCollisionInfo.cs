// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.GameplayLocationCollisionInfo
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayLocationCollisionInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PathBlocking;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetBlocking;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElevateValidMinMaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnorePathBlockingUntilUnblocked;
    [FieldOffset(0)]
    public MapCollisionFlags PathBlocking;
    [FieldOffset(1)]
    public MapCollisionFlags TargetBlocking;
    [FieldOffset(4)]
    public float Radius;
    [FieldOffset(8)]
    public float MinHeightDiff;
    [FieldOffset(12)]
    public float MaxHeightDiff;
    [FieldOffset(16)]
    public bool ElevateValidMinMaxHeight;
    [FieldOffset(17)]
    public bool IgnorePathBlockingUntilUnblocked;

    static GameplayLocationCollisionInfo()
    {
      Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay", nameof (GameplayLocationCollisionInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr);
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_PathBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (PathBlocking));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_TargetBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (TargetBlocking));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (Radius));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_MinHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (MinHeightDiff));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_MaxHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (MaxHeightDiff));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_ElevateValidMinMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (ElevateValidMinMaxHeight));
      GameplayLocationCollisionInfo.NativeFieldInfoPtr_IgnorePathBlockingUntilUnblocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, nameof (IgnorePathBlockingUntilUnblocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayLocationCollisionInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
