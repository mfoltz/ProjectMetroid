// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitStatModifiers
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
  public class UnitStatModifiers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 758706, RefRangeEnd = 758708, XrefRangeStart = 758704, XrefRangeEnd = 758706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitStatModifiers.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnitStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitStatModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitStatModifiers()
    {
      Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitStatModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr);
      UnitStatModifiers.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, nameof (MaxHealthModifier));
      UnitStatModifiers.NativeFieldInfoPtr_PowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, nameof (PowerModifier));
      UnitStatModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, 100666950);
      UnitStatModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, 100666951);
      UnitStatModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, 100666952);
    }

    public UnitStatModifiers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MaxHealthModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatModifiers.NativeFieldInfoPtr_MaxHealthModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatModifiers.NativeFieldInfoPtr_MaxHealthModifier)) = value;
      }
    }

    public unsafe float PowerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatModifiers.NativeFieldInfoPtr_PowerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatModifiers.NativeFieldInfoPtr_PowerModifier)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_PowerModifier;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0;
      [FieldOffset(0)]
      public half MaxHealthModifier;
      [FieldOffset(2)]
      public half PowerModifier;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758670, RefRangeEnd = 758672, XrefRangeStart = 758665, XrefRangeEnd = 758670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        [In] ref UnitStatModifiers.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758677, RefRangeEnd = 758679, XrefRangeStart = 758672, XrefRangeEnd = 758677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe UnitStatModifiers.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(UnitStatModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758685, RefRangeEnd = 758687, XrefRangeStart = 758679, XrefRangeEnd = 758685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758703, RefRangeEnd = 758704, XrefRangeStart = 758687, XrefRangeEnd = 758703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AppendToString(StringBuilder stringBuilder, string prefix)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitStatModifiers>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr);
        UnitStatModifiers.StructData.NativeFieldInfoPtr_MaxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, nameof (MaxHealthModifier));
        UnitStatModifiers.StructData.NativeFieldInfoPtr_PowerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, nameof (PowerModifier));
        UnitStatModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, 100666953);
        UnitStatModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, 100666954);
        UnitStatModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, 100666955);
        UnitStatModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, 100666956);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitStatModifiers.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
