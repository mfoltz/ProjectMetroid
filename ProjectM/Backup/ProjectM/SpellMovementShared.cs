// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellMovementShared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class SpellMovementShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SpellUpdate_Internal_Static_Void_byref_SpellMovement_byref_LifeTime_byref_Age_CurveCollection_Boolean_byref_PrefabGUID_byref_float3_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1039835, RefRangeEnd = 1039837, XrefRangeStart = 1039813, XrefRangeEnd = 1039835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpellUpdate(
      [In] ref SpellMovement spellMovement,
      [In] ref LifeTime lifeTime,
      [In] ref Age age,
      CurveCollection curveCollection,
      bool isServer,
      [In] ref PrefabGUID prefabGuid,
      out float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref spellMovement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellMovementShared.NativeMethodInfoPtr_SpellUpdate_Internal_Static_Void_byref_SpellMovement_byref_LifeTime_byref_Age_CurveCollection_Boolean_byref_PrefabGUID_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellMovementShared()
    {
      Il2CppClassPointerStore<SpellMovementShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpellMovementShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellMovementShared>.NativeClassPtr);
      SpellMovementShared.NativeMethodInfoPtr_SpellUpdate_Internal_Static_Void_byref_SpellMovement_byref_LifeTime_byref_Age_CurveCollection_Boolean_byref_PrefabGUID_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMovementShared>.NativeClassPtr, 100681435);
    }

    public SpellMovementShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
