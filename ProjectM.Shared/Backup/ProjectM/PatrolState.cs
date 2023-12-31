// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolState
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
  public struct PatrolState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToWaypoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathEntity;
    [FieldOffset(0)]
    public Entity FromWaypoint;
    [FieldOffset(8)]
    public Entity ToWaypoint;
    [FieldOffset(16)]
    public Entity PathEntity;

    static PatrolState()
    {
      Il2CppClassPointerStore<PatrolState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PatrolState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolState>.NativeClassPtr);
      PatrolState.NativeFieldInfoPtr_FromWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolState>.NativeClassPtr, nameof (FromWaypoint));
      PatrolState.NativeFieldInfoPtr_ToWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolState>.NativeClassPtr, nameof (ToWaypoint));
      PatrolState.NativeFieldInfoPtr_PathEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolState>.NativeClassPtr, nameof (PathEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
