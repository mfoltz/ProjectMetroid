// Decompiled with JetBrains decompiler
// Type: ProjectM.GlobalPatrolState
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
  public struct GlobalPatrolState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartBusStopIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentBusStopIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetBusStopIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathRequestEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PatrolType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    [FieldOffset(0)]
    public int StartBusStopIndex;
    [FieldOffset(4)]
    public int CurrentBusStopIndex;
    [FieldOffset(8)]
    public int TargetBusStopIndex;
    [FieldOffset(12)]
    public Entity PathRequestEntity;
    [FieldOffset(20)]
    public GlobalPatrolType PatrolType;
    [FieldOffset(24)]
    public GlobalPatrolDirection Direction;

    static GlobalPatrolState()
    {
      Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GlobalPatrolState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr);
      GlobalPatrolState.NativeFieldInfoPtr_StartBusStopIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (StartBusStopIndex));
      GlobalPatrolState.NativeFieldInfoPtr_CurrentBusStopIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (CurrentBusStopIndex));
      GlobalPatrolState.NativeFieldInfoPtr_TargetBusStopIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (TargetBusStopIndex));
      GlobalPatrolState.NativeFieldInfoPtr_PathRequestEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (PathRequestEntity));
      GlobalPatrolState.NativeFieldInfoPtr_PatrolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (PatrolType));
      GlobalPatrolState.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (Direction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Initialized
    {
      static Initialized()
      {
        Il2CppClassPointerStore<GlobalPatrolState.Initialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalPatrolState>.NativeClassPtr, nameof (Initialized));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalPatrolState.Initialized>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalPatrolState.Initialized>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
