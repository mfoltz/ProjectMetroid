// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderModifiers
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
  public class TraderModifiers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StockModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PriceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestockTimerModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758946, XrefRangeEnd = 758949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderModifiers.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TraderModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderModifiers()
    {
      Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TraderModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr);
      TraderModifiers.NativeFieldInfoPtr_StockModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, nameof (StockModifier));
      TraderModifiers.NativeFieldInfoPtr_PriceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, nameof (PriceModifier));
      TraderModifiers.NativeFieldInfoPtr_RestockTimerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, nameof (RestockTimerModifier));
      TraderModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, 100666971);
      TraderModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, 100666972);
      TraderModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, 100666973);
    }

    public TraderModifiers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float StockModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_StockModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_StockModifier)) = value;
      }
    }

    public unsafe float PriceModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_PriceModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_PriceModifier)) = value;
      }
    }

    public unsafe float RestockTimerModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_RestockTimerModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderModifiers.NativeFieldInfoPtr_RestockTimerModifier)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StockModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_PriceModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_RestockTimerModifier;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      [FieldOffset(0)]
      public half StockModifier;
      [FieldOffset(2)]
      public half PriceModifier;
      [FieldOffset(4)]
      public half RestockTimerModifier;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758902, XrefRangeEnd = 758908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        [In] ref TraderModifiers.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TraderModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758908, XrefRangeEnd = 758914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TraderModifiers.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TraderModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758914, XrefRangeEnd = 758937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AppendToString(StringBuilder stringBuilder, string prefix)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TraderModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758937, XrefRangeEnd = 758946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TraderModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TraderModifiers>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr);
        TraderModifiers.StructData.NativeFieldInfoPtr_StockModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, nameof (StockModifier));
        TraderModifiers.StructData.NativeFieldInfoPtr_PriceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, nameof (PriceModifier));
        TraderModifiers.StructData.NativeFieldInfoPtr_RestockTimerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, nameof (RestockTimerModifier));
        TraderModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, 100666974);
        TraderModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, 100666975);
        TraderModifiers.StructData.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, 100666976);
        TraderModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, 100666977);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderModifiers.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
