// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityTypeModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityTypeModifiers
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Human;
    private static readonly System.IntPtr NativeFieldInfoPtr_Undead;
    private static readonly System.IntPtr NativeFieldInfoPtr_Demon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mechanical;
    private static readonly System.IntPtr NativeFieldInfoPtr_Beast;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVampire;
    private static readonly System.IntPtr NativeFieldInfoPtr_BasicStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReinforcedStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_FortifiedStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoneStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeAltar;
    private static readonly System.IntPtr NativeFieldInfoPtr_Wood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Minerals;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vegetation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightArmor;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Magic;
    private static readonly System.IntPtr NativeFieldInfoPtr_Explosives;
    private static readonly System.IntPtr NativeFieldInfoPtr_MassiveResource;
    private static readonly System.IntPtr NativeFieldInfoPtr_MonsterGate;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EntityTypeModifiers_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetModifier_Public_Single_EntityCategory_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasSufficientResourceLevel_Public_Boolean_EntityCategory_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialModifier_Public_Single_EntityCategory_0;
    [FieldOffset(0)]
    public float Human;
    [FieldOffset(4)]
    public float Undead;
    [FieldOffset(8)]
    public float Demon;
    [FieldOffset(12)]
    public float Mechanical;
    [FieldOffset(16)]
    public float Beast;
    [FieldOffset(20)]
    public float CastleObject;
    [FieldOffset(24)]
    public float PlayerVampire;
    [FieldOffset(28)]
    public float BasicStructure;
    [FieldOffset(32)]
    public float ReinforcedStructure;
    [FieldOffset(36)]
    public float FortifiedStructure;
    [FieldOffset(40)]
    public float StoneStructure;
    [FieldOffset(44)]
    public float SiegeAltar;
    [FieldOffset(48)]
    public float Wood;
    [FieldOffset(52)]
    public float Minerals;
    [FieldOffset(56)]
    public float Vegetation;
    [FieldOffset(60)]
    public float LightArmor;
    [FieldOffset(64)]
    public float VBlood;
    [FieldOffset(68)]
    public float Magic;
    [FieldOffset(72)]
    public float Explosives;
    [FieldOffset(76)]
    public float MassiveResource;
    [FieldOffset(80)]
    public float MonsterGate;

    public static unsafe EntityTypeModifiers Default
    {
      [CallerCount(17), CachedScanResults(RefRangeStart = 737223, RefRangeEnd = 737240, XrefRangeStart = 737223, XrefRangeEnd = 737223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityTypeModifiers.NativeMethodInfoPtr_get_Default_Public_Static_get_EntityTypeModifiers_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityTypeModifiers*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737240, RefRangeEnd = 737241, XrefRangeStart = 737240, XrefRangeEnd = 737240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetModifier(EntityCategory targetEntityCategory, float attackLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &targetEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &attackLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityTypeModifiers.NativeMethodInfoPtr_GetModifier_Public_Single_EntityCategory_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737241, RefRangeEnd = 737242, XrefRangeStart = 737241, XrefRangeEnd = 737241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasSufficientResourceLevel(
      EntityCategory targetEntityCategory,
      float attackLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &targetEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &attackLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityTypeModifiers.NativeMethodInfoPtr_HasSufficientResourceLevel_Public_Boolean_EntityCategory_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737242, RefRangeEnd = 737243, XrefRangeStart = 737242, XrefRangeEnd = 737242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetMaterialModifier(EntityCategory targetEntityCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &targetEntityCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityTypeModifiers.NativeMethodInfoPtr_GetMaterialModifier_Public_Single_EntityCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityTypeModifiers()
    {
      Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityTypeModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr);
      EntityTypeModifiers.NativeFieldInfoPtr_Human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Human));
      EntityTypeModifiers.NativeFieldInfoPtr_Undead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Undead));
      EntityTypeModifiers.NativeFieldInfoPtr_Demon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Demon));
      EntityTypeModifiers.NativeFieldInfoPtr_Mechanical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Mechanical));
      EntityTypeModifiers.NativeFieldInfoPtr_Beast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Beast));
      EntityTypeModifiers.NativeFieldInfoPtr_CastleObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (CastleObject));
      EntityTypeModifiers.NativeFieldInfoPtr_PlayerVampire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (PlayerVampire));
      EntityTypeModifiers.NativeFieldInfoPtr_BasicStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (BasicStructure));
      EntityTypeModifiers.NativeFieldInfoPtr_ReinforcedStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (ReinforcedStructure));
      EntityTypeModifiers.NativeFieldInfoPtr_FortifiedStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (FortifiedStructure));
      EntityTypeModifiers.NativeFieldInfoPtr_StoneStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (StoneStructure));
      EntityTypeModifiers.NativeFieldInfoPtr_SiegeAltar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (SiegeAltar));
      EntityTypeModifiers.NativeFieldInfoPtr_Wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Wood));
      EntityTypeModifiers.NativeFieldInfoPtr_Minerals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Minerals));
      EntityTypeModifiers.NativeFieldInfoPtr_Vegetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Vegetation));
      EntityTypeModifiers.NativeFieldInfoPtr_LightArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (LightArmor));
      EntityTypeModifiers.NativeFieldInfoPtr_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (VBlood));
      EntityTypeModifiers.NativeFieldInfoPtr_Magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Magic));
      EntityTypeModifiers.NativeFieldInfoPtr_Explosives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (Explosives));
      EntityTypeModifiers.NativeFieldInfoPtr_MassiveResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (MassiveResource));
      EntityTypeModifiers.NativeFieldInfoPtr_MonsterGate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, nameof (MonsterGate));
      EntityTypeModifiers.NativeMethodInfoPtr_get_Default_Public_Static_get_EntityTypeModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, 100665116);
      EntityTypeModifiers.NativeMethodInfoPtr_GetModifier_Public_Single_EntityCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, 100665117);
      EntityTypeModifiers.NativeMethodInfoPtr_HasSufficientResourceLevel_Public_Boolean_EntityCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, 100665118);
      EntityTypeModifiers.NativeMethodInfoPtr_GetMaterialModifier_Public_Single_EntityCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, 100665119);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityTypeModifiers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
