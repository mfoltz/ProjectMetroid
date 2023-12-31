// Decompiled with JetBrains decompiler
// Type: ProjectM.HeightPlacementConfig
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Physics;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HeightPlacementConfig
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardCollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilterFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverridePickingPivot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsePlayerPickingPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviewHeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapToClosestStandardHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_HeightPlacementConfig_0;
    [FieldOffset(0)]
    public CollisionFilterFlags CollisionFilterFlags;
    [FieldOffset(4)]
    public Nullable_Unboxed<float3> OverridePickingPivot;
    [FieldOffset(20)]
    public bool UsePlayerPickingPlane;
    [FieldOffset(24)]
    public float PreviewHeightOffset;
    [FieldOffset(28)]
    public bool SnapToClosestStandardHeight;

    public static unsafe HeightPlacementConfig Default
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeightPlacementConfig.NativeMethodInfoPtr_get_Default_Public_Static_get_HeightPlacementConfig_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HeightPlacementConfig*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static HeightPlacementConfig()
    {
      Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeightPlacementConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr);
      HeightPlacementConfig.NativeFieldInfoPtr_StandardCollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (StandardCollisionFilter));
      HeightPlacementConfig.NativeFieldInfoPtr_CollisionFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (CollisionFilterFlags));
      HeightPlacementConfig.NativeFieldInfoPtr_OverridePickingPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (OverridePickingPivot));
      HeightPlacementConfig.NativeFieldInfoPtr_UsePlayerPickingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (UsePlayerPickingPlane));
      HeightPlacementConfig.NativeFieldInfoPtr_PreviewHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (PreviewHeightOffset));
      HeightPlacementConfig.NativeFieldInfoPtr_SnapToClosestStandardHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, nameof (SnapToClosestStandardHeight));
      HeightPlacementConfig.NativeMethodInfoPtr_get_Default_Public_Static_get_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, 100664690);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeightPlacementConfig>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe CollisionFilterFlags StandardCollisionFilter
    {
      get
      {
        CollisionFilterFlags standardCollisionFilter;
        IL2CPP.il2cpp_field_static_get_value(HeightPlacementConfig.NativeFieldInfoPtr_StandardCollisionFilter, (void*) &standardCollisionFilter);
        return standardCollisionFilter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightPlacementConfig.NativeFieldInfoPtr_StandardCollisionFilter, (void*) &value);
      }
    }
  }
}
