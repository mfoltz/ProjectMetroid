// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityInput
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityInput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileAimPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPositionPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredEntityNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileAimType;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAllAimPositions_Public_Void_float3_0;
    [FieldOffset(0)]
    public float2 Movement;
    [FieldOffset(8)]
    public float3 AimPosition;
    [FieldOffset(20)]
    public float3 ProjectileAimPosition;
    [FieldOffset(32)]
    public float3 AimDirection;
    [FieldOffset(44)]
    public float AimLength;
    [FieldOffset(48)]
    public float3 AimPositionPlane;
    [FieldOffset(60)]
    public Entity HoveredEntity;
    [FieldOffset(68)]
    public NetworkId HoveredEntityNetworkId;
    [FieldOffset(76)]
    public SyncedInputState State;
    [FieldOffset(128)]
    public AimDirectionType ProjectileAimType;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 740823, RefRangeEnd = 740826, XrefRangeStart = 740823, XrefRangeEnd = 740823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAimDirectionPlane(float3 playerPosition, out float3 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityInput.NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 740826, RefRangeEnd = 740831, XrefRangeStart = 740826, XrefRangeEnd = 740826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAllAimPositions(float3 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityInput.NativeMethodInfoPtr_SetAllAimPositions_Public_Void_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EntityInput()
    {
      Il2CppClassPointerStore<EntityInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityInput>.NativeClassPtr);
      EntityInput.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (Movement));
      EntityInput.NativeFieldInfoPtr_AimPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (AimPosition));
      EntityInput.NativeFieldInfoPtr_ProjectileAimPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (ProjectileAimPosition));
      EntityInput.NativeFieldInfoPtr_AimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (AimDirection));
      EntityInput.NativeFieldInfoPtr_AimLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (AimLength));
      EntityInput.NativeFieldInfoPtr_AimPositionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (AimPositionPlane));
      EntityInput.NativeFieldInfoPtr_HoveredEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (HoveredEntity));
      EntityInput.NativeFieldInfoPtr_HoveredEntityNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (HoveredEntityNetworkId));
      EntityInput.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (State));
      EntityInput.NativeFieldInfoPtr_ProjectileAimType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, nameof (ProjectileAimType));
      EntityInput.NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, 100665393);
      EntityInput.NativeMethodInfoPtr_SetAllAimPositions_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, 100665394);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
