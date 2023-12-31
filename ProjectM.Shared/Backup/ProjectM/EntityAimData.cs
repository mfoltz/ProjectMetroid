// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityAimData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityAimData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPositionPlane;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileAimPosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAimDirection_Public_Boolean_float3_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAimDirectionProjectile_Public_Boolean_float3_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0;
    [FieldOffset(0)]
    public float3 AimPosition;
    [FieldOffset(12)]
    public float3 AimPositionPlane;
    [FieldOffset(24)]
    public float3 ProjectileAimPosition;

    [CallerCount(0)]
    public unsafe bool TryGetAimDirection(float3 playerPosition, out float3 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityAimData.NativeMethodInfoPtr_TryGetAimDirection_Public_Boolean_float3_byref_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 740831, RefRangeEnd = 740832, XrefRangeStart = 740831, XrefRangeEnd = 740831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAimDirectionProjectile(float3 playerPosition, out float3 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityAimData.NativeMethodInfoPtr_TryGetAimDirectionProjectile_Public_Boolean_float3_byref_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 740832, RefRangeEnd = 740843, XrefRangeStart = 740832, XrefRangeEnd = 740832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAimDirectionPlane(float3 playerPosition, out float3 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityAimData.NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityAimData()
    {
      Il2CppClassPointerStore<EntityAimData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityAimData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr);
      EntityAimData.NativeFieldInfoPtr_AimPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, nameof (AimPosition));
      EntityAimData.NativeFieldInfoPtr_AimPositionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, nameof (AimPositionPlane));
      EntityAimData.NativeFieldInfoPtr_ProjectileAimPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, nameof (ProjectileAimPosition));
      EntityAimData.NativeMethodInfoPtr_TryGetAimDirection_Public_Boolean_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, 100665395);
      EntityAimData.NativeMethodInfoPtr_TryGetAimDirectionProjectile_Public_Boolean_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, 100665396);
      EntityAimData.NativeMethodInfoPtr_TryGetAimDirectionPlane_Public_Boolean_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, 100665397);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAimData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
