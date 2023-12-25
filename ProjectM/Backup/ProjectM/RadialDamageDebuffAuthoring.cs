// Decompiled with JetBrains decompiler
// Type: ProjectM.RadialDamageDebuffAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RadialDamageDebuffAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OuterDamagePerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_InnerDamagePerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_OuterRadius;
    private static readonly IntPtr NativeFieldInfoPtr_InnerRadius;
    private static readonly IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly IntPtr NativeFieldInfoPtr_DamageIncrements;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031843, XrefRangeEnd = 1031846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RadialDamageDebuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031846, XrefRangeEnd = 1031847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RadialDamageDebuffAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RadialDamageDebuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RadialDamageDebuffAuthoring()
    {
      Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RadialDamageDebuffAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr);
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterDamagePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (OuterDamagePerSecond));
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerDamagePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (InnerDamagePerSecond));
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (OuterRadius));
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (InnerRadius));
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (DamageType));
      RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageIncrements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, nameof (DamageIncrements));
      RadialDamageDebuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, 100680592);
      RadialDamageDebuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialDamageDebuffAuthoring>.NativeClassPtr, 100680593);
    }

    public RadialDamageDebuffAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float OuterDamagePerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterDamagePerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterDamagePerSecond)) = value;
      }
    }

    public unsafe float InnerDamagePerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerDamagePerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerDamagePerSecond)) = value;
      }
    }

    public unsafe float OuterRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_OuterRadius)) = value;
      }
    }

    public unsafe float InnerRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_InnerRadius)) = value;
      }
    }

    public unsafe MainDamageType DamageType
    {
      get
      {
        return *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageType));
      }
      [param: In] set
      {
        *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageType)) = value;
      }
    }

    public unsafe float DamageIncrements
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageIncrements));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RadialDamageDebuffAuthoring.NativeFieldInfoPtr_DamageIncrements)) = value;
      }
    }
  }
}
