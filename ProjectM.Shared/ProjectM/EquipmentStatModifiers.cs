// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentStatModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class EquipmentStatModifiers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxEnergyModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceYieldModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeedModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758901, RefRangeEnd = 758902, XrefRangeStart = 758894, XrefRangeEnd = 758901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquipmentStatModifiers.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EquipmentStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquipmentStatModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EquipmentStatModifiers()
    {
      Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EquipmentStatModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr);
      EquipmentStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (MaxEnergyModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (MaxHealthModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (ResourceYieldModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (PhysicalPowerModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_SpellPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (SpellPowerModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_SiegePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (SiegePowerModifier));
      EquipmentStatModifiers.NativeFieldInfoPtr_MovementSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (MovementSpeedModifier));
      EquipmentStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, 100666964);
      EquipmentStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, 100666965);
      EquipmentStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, 100666966);
    }

    public EquipmentStatModifiers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MaxEnergyModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier)) = value;
      }
    }

    public unsafe float MaxHealthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MaxHealthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MaxHealthModifier)) = value;
      }
    }

    public unsafe float ResourceYieldModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_ResourceYieldModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_ResourceYieldModifier)) = value;
      }
    }

    public unsafe float PhysicalPowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier)) = value;
      }
    }

    public unsafe float SpellPowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_SpellPowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_SpellPowerModifier)) = value;
      }
    }

    public unsafe float SiegePowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_SiegePowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_SiegePowerModifier)) = value;
      }
    }

    public unsafe float MovementSpeedModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MovementSpeedModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentStatModifiers.NativeFieldInfoPtr_MovementSpeedModifier)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxEnergyModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourceYieldModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeedModifier;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      [FieldOffset(0)]
      public half MaxEnergyModifier;
      [FieldOffset(2)]
      public half MaxHealthModifier;
      [FieldOffset(4)]
      public half ResourceYieldModifier;
      [FieldOffset(6)]
      public half PhysicalPowerModifier;
      [FieldOffset(8)]
      public half SpellPowerModifier;
      [FieldOffset(10)]
      public half SiegePowerModifier;
      [FieldOffset(12)]
      public half MovementSpeedModifier;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758808, RefRangeEnd = 758809, XrefRangeStart = 758798, XrefRangeEnd = 758808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        [In] ref EquipmentStatModifiers.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758819, RefRangeEnd = 758820, XrefRangeStart = 758809, XrefRangeEnd = 758819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EquipmentStatModifiers.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EquipmentStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758871, RefRangeEnd = 758872, XrefRangeStart = 758820, XrefRangeEnd = 758871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AppendToString(StringBuilder stringBuilder, string prefix)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758893, RefRangeEnd = 758894, XrefRangeStart = 758872, XrefRangeEnd = 758893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipmentStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipmentStatModifiers>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr);
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_MaxEnergyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (MaxEnergyModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (MaxHealthModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (ResourceYieldModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_PhysicalPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (PhysicalPowerModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_SpellPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (SpellPowerModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_SiegePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (SiegePowerModifier));
        EquipmentStatModifiers.StructData.NativeFieldInfoPtr_MovementSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, nameof (MovementSpeedModifier));
        EquipmentStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, 100666967);
        EquipmentStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, 100666968);
        EquipmentStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, 100666969);
        EquipmentStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, 100666970);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipmentStatModifiers.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
