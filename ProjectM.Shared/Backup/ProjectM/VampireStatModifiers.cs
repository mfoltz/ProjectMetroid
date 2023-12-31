// Decompiled with JetBrains decompiler
// Type: ProjectM.VampireStatModifiers
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
  public class VampireStatModifiers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxEnergyModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourcePowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageReceivedModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReviveCancelDelay;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758797, RefRangeEnd = 758798, XrefRangeStart = 758789, XrefRangeEnd = 758797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VampireStatModifiers.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(VampireStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VampireStatModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VampireStatModifiers()
    {
      Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VampireStatModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr);
      VampireStatModifiers.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (MaxHealthModifier));
      VampireStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (MaxEnergyModifier));
      VampireStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (PhysicalPowerModifier));
      VampireStatModifiers.NativeFieldInfoPtr_SpellPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (SpellPowerModifier));
      VampireStatModifiers.NativeFieldInfoPtr_ResourcePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (ResourcePowerModifier));
      VampireStatModifiers.NativeFieldInfoPtr_SiegePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (SiegePowerModifier));
      VampireStatModifiers.NativeFieldInfoPtr_DamageReceivedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (DamageReceivedModifier));
      VampireStatModifiers.NativeFieldInfoPtr_ReviveCancelDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (ReviveCancelDelay));
      VampireStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, 100666957);
      VampireStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, 100666958);
      VampireStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, 100666959);
    }

    public VampireStatModifiers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MaxHealthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_MaxHealthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_MaxHealthModifier)) = value;
      }
    }

    public unsafe float MaxEnergyModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_MaxEnergyModifier)) = value;
      }
    }

    public unsafe float PhysicalPowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_PhysicalPowerModifier)) = value;
      }
    }

    public unsafe float SpellPowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_SpellPowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_SpellPowerModifier)) = value;
      }
    }

    public unsafe float ResourcePowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_ResourcePowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_ResourcePowerModifier)) = value;
      }
    }

    public unsafe float SiegePowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_SiegePowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_SiegePowerModifier)) = value;
      }
    }

    public unsafe float DamageReceivedModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_DamageReceivedModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_DamageReceivedModifier)) = value;
      }
    }

    public unsafe float ReviveCancelDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_ReviveCancelDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireStatModifiers.NativeFieldInfoPtr_ReviveCancelDelay)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxEnergyModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellPowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourcePowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_SiegePowerModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageReceivedModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReviveCancelDelay;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      [FieldOffset(0)]
      public half MaxHealthModifier;
      [FieldOffset(2)]
      public half MaxEnergyModifier;
      [FieldOffset(4)]
      public half PhysicalPowerModifier;
      [FieldOffset(6)]
      public half SpellPowerModifier;
      [FieldOffset(8)]
      public half ResourcePowerModifier;
      [FieldOffset(10)]
      public half SiegePowerModifier;
      [FieldOffset(12)]
      public half DamageReceivedModifier;
      [FieldOffset(14)]
      public half ReviveCancelDelay;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758719, RefRangeEnd = 758720, XrefRangeStart = 758708, XrefRangeEnd = 758719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        [In] ref VampireStatModifiers.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758731, RefRangeEnd = 758732, XrefRangeStart = 758720, XrefRangeEnd = 758731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe VampireStatModifiers.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(VampireStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758769, RefRangeEnd = 758770, XrefRangeStart = 758732, XrefRangeEnd = 758769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AppendToString(StringBuilder stringBuilder, string prefix)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758788, RefRangeEnd = 758789, XrefRangeStart = 758770, XrefRangeEnd = 758788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VampireStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VampireStatModifiers>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr);
        VampireStatModifiers.StructData.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (MaxHealthModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_MaxEnergyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (MaxEnergyModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_PhysicalPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (PhysicalPowerModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_SpellPowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (SpellPowerModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_ResourcePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (ResourcePowerModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_SiegePowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (SiegePowerModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_DamageReceivedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (DamageReceivedModifier));
        VampireStatModifiers.StructData.NativeFieldInfoPtr_ReviveCancelDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, nameof (ReviveCancelDelay));
        VampireStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, 100666960);
        VampireStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, 100666961);
        VampireStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, 100666962);
        VampireStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, 100666963);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VampireStatModifiers.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
