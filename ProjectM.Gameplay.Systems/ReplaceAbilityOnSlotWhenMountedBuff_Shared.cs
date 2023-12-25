// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotWhenMountedBuff_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ReplaceAbilityOnSlotWhenMountedBuff_Shared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearModifications_Internal_Static_Void_EntityManager_byref_ToModifyData_EntityCommandBuffer_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1416235, RefRangeEnd = 1416237, XrefRangeStart = 1416200, XrefRangeEnd = 1416235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearModifications(
      EntityManager entityManager,
      [In] ref ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData data,
      EntityCommandBuffer ecb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ecb;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuff_Shared.NativeMethodInfoPtr_ClearModifications_Internal_Static_Void_EntityManager_byref_ToModifyData_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceAbilityOnSlotWhenMountedBuff_Shared()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ReplaceAbilityOnSlotWhenMountedBuff_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared>.NativeClassPtr);
      ReplaceAbilityOnSlotWhenMountedBuff_Shared.NativeMethodInfoPtr_ClearModifications_Internal_Static_Void_EntityManager_byref_ToModifyData_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared>.NativeClassPtr, 100669193);
    }

    public ReplaceAbilityOnSlotWhenMountedBuff_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ToModifyData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
      [FieldOffset(0)]
      public Entity BuffEntity;
      [FieldOffset(8)]
      public Entity TargetEntity;

      static ToModifyData()
      {
        Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared>.NativeClassPtr, nameof (ToModifyData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>.NativeClassPtr);
        ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData.NativeFieldInfoPtr_BuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>.NativeClassPtr, nameof (BuffEntity));
        ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>.NativeClassPtr, nameof (TargetEntity));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
