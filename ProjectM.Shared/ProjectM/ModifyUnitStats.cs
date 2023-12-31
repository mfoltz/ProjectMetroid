// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyUnitStats
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyUnitStats
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_RadialDamageTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeDamageInSun;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeLeech;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vision;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatModifications;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntModifications;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModifyUnitStats_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_ModificationStructure_byref_ModifyUnitStatBuff_DOTS_Entity_Entity_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Modify_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_0;
    [FieldOffset(0)]
    public ComponentDataFromEntity<ProjectM.UnitStats> UnitStats;
    [FieldOffset(32)]
    public ComponentDataFromEntity<ResistCategoryStats> ResistStats;
    [FieldOffset(64)]
    public ComponentDataFromEntity<DamageCategoryStats> DamageStats;
    [FieldOffset(96)]
    public ComponentDataFromEntity<ProjectM.RadialDamageTarget> RadialDamageTarget;
    [FieldOffset(128)]
    public ComponentDataFromEntity<ProjectM.Health> Health;
    [FieldOffset(160)]
    public ComponentDataFromEntity<ProjectM.Blood> Blood;
    [FieldOffset(192)]
    public ComponentDataFromEntity<ProjectM.Movement> Movement;
    [FieldOffset(224)]
    public ComponentDataFromEntity<ProjectM.Energy> Energy;
    [FieldOffset(256)]
    public ComponentDataFromEntity<ProjectM.TakeDamageInSun> TakeDamageInSun;
    [FieldOffset(288)]
    public ComponentDataFromEntity<ProjectM.LifeLeech> LifeLeech;
    [FieldOffset(320)]
    public ComponentDataFromEntity<ProjectM.Vision> Vision;
    [FieldOffset(352)]
    public ComponentDataFromEntity<AbilityBar_Shared> AbilityBar;
    [FieldOffset(384)]
    public ComponentDataFromEntity<ProjectM.Shared.FallToHeight> FallToHeight;
    [FieldOffset(416)]
    public BufferFromEntity<FloatModificationBuffer> FloatModifications;
    [FieldOffset(456)]
    public BufferFromEntity<IntModificationBuffer> IntModifications;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 739765, RefRangeEnd = 739768, XrefRangeStart = 739719, XrefRangeEnd = 739765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModifyUnitStats Create(SystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyUnitStats.NativeMethodInfoPtr_Create_Public_Static_ModifyUnitStats_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModifyUnitStats*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 739818, RefRangeEnd = 739819, XrefRangeStart = 739768, XrefRangeEnd = 739818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Apply(
      ModificationStructure modificationStruct,
      ref ModifyUnitStatBuff_DOTS data,
      Entity source,
      Entity target,
      byte stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &modificationStruct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStats.NativeMethodInfoPtr_Apply_Public_Void_ModificationStructure_byref_ModifyUnitStatBuff_DOTS_Entity_Entity_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 740152, RefRangeEnd = 740153, XrefRangeStart = 739819, XrefRangeEnd = 740152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Modify(ref ModifyUnitStatBuff_DOTS data, Entity target, byte stacks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStats.NativeMethodInfoPtr_Modify_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 740206, RefRangeEnd = 740208, XrefRangeStart = 740153, XrefRangeEnd = 740206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(ref ModifyUnitStatBuff_DOTS data, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStats.NativeMethodInfoPtr_Remove_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyUnitStats()
    {
      Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyUnitStats));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr);
      ModifyUnitStats.NativeFieldInfoPtr_UnitStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (UnitStats));
      ModifyUnitStats.NativeFieldInfoPtr_ResistStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (ResistStats));
      ModifyUnitStats.NativeFieldInfoPtr_DamageStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (DamageStats));
      ModifyUnitStats.NativeFieldInfoPtr_RadialDamageTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (RadialDamageTarget));
      ModifyUnitStats.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (Health));
      ModifyUnitStats.NativeFieldInfoPtr_Blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (Blood));
      ModifyUnitStats.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (Movement));
      ModifyUnitStats.NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (Energy));
      ModifyUnitStats.NativeFieldInfoPtr_TakeDamageInSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (TakeDamageInSun));
      ModifyUnitStats.NativeFieldInfoPtr_LifeLeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (LifeLeech));
      ModifyUnitStats.NativeFieldInfoPtr_Vision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (Vision));
      ModifyUnitStats.NativeFieldInfoPtr_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (AbilityBar));
      ModifyUnitStats.NativeFieldInfoPtr_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (FallToHeight));
      ModifyUnitStats.NativeFieldInfoPtr_FloatModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (FloatModifications));
      ModifyUnitStats.NativeFieldInfoPtr_IntModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, nameof (IntModifications));
      ModifyUnitStats.NativeMethodInfoPtr_Create_Public_Static_ModifyUnitStats_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, 100665280);
      ModifyUnitStats.NativeMethodInfoPtr_Apply_Public_Void_ModificationStructure_byref_ModifyUnitStatBuff_DOTS_Entity_Entity_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, 100665281);
      ModifyUnitStats.NativeMethodInfoPtr_Modify_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, 100665282);
      ModifyUnitStats.NativeMethodInfoPtr_Remove_Public_Void_byref_ModifyUnitStatBuff_DOTS_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, 100665283);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStats>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
