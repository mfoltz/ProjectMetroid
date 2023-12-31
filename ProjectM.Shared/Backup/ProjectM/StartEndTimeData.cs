// Decompiled with JetBrains decompiler
// Type: ProjectM.StartEndTimeData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class StartEndTimeData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndMinute;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTime_Public_Void_StartEndTimeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 758501, RefRangeEnd = 758505, XrefRangeStart = 758501, XrefRangeEnd = 758501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartEndTimeData.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StartEndTimeData.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 758505, RefRangeEnd = 758509, XrefRangeStart = 758505, XrefRangeEnd = 758505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyTime(StartEndTimeData from)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.NativeMethodInfoPtr_CopyTime_Public_Void_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758509, XrefRangeEnd = 758510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartEndTimeData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StartEndTimeData()
    {
      Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StartEndTimeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr);
      StartEndTimeData.NativeFieldInfoPtr_StartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, nameof (StartHour));
      StartEndTimeData.NativeFieldInfoPtr_StartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, nameof (StartMinute));
      StartEndTimeData.NativeFieldInfoPtr_EndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, nameof (EndHour));
      StartEndTimeData.NativeFieldInfoPtr_EndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, nameof (EndMinute));
      StartEndTimeData.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, 100666927);
      StartEndTimeData.NativeMethodInfoPtr_CopyTime_Public_Void_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, 100666928);
      StartEndTimeData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, 100666929);
      StartEndTimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, 100666930);
    }

    public StartEndTimeData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe byte StartHour
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_StartHour));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_StartHour)) = value;
      }
    }

    public unsafe byte StartMinute
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_StartMinute));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_StartMinute)) = value;
      }
    }

    public unsafe byte EndHour
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_EndHour));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_EndHour)) = value;
      }
    }

    public unsafe byte EndMinute
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_EndMinute));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartEndTimeData.NativeFieldInfoPtr_EndMinute)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StartHour;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartMinute;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndHour;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndMinute;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_StartTimeInMinutes_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTimeInMinutes_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsWithinSpan_Public_Boolean_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetStartTimeFormatted_Public_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEndTimeFormatted_Public_String_0;
      [FieldOffset(0)]
      public byte StartHour;
      [FieldOffset(1)]
      public byte StartMinute;
      [FieldOffset(2)]
      public byte EndHour;
      [FieldOffset(3)]
      public byte EndMinute;

      public unsafe int StartTimeInMinutes
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 758441, RefRangeEnd = 758445, XrefRangeStart = 758441, XrefRangeEnd = 758441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_get_StartTimeInMinutes_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe int EndTimeInMinutes
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 758445, RefRangeEnd = 758449, XrefRangeStart = 758445, XrefRangeEnd = 758445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_get_EndTimeInMinutes_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 758453, RefRangeEnd = 758457, XrefRangeStart = 758449, XrefRangeEnd = 758453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        StartEndTimeData.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 758461, RefRangeEnd = 758467, XrefRangeStart = 758457, XrefRangeEnd = 758461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe StartEndTimeData.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(StartEndTimeData.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758467, RefRangeEnd = 758469, XrefRangeStart = 758467, XrefRangeEnd = 758467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsWithinSpan(int hour, int minute)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &hour;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minute;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_IsWithinSpan_Public_Boolean_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758483, RefRangeEnd = 758485, XrefRangeStart = 758469, XrefRangeEnd = 758483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string GetStartTimeFormatted()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_GetStartTimeFormatted_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 758499, RefRangeEnd = 758501, XrefRangeStart = 758485, XrefRangeEnd = 758499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string GetEndTimeFormatted()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StartEndTimeData.StructData.NativeMethodInfoPtr_GetEndTimeFormatted_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static StructData()
      {
        Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartEndTimeData>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr);
        StartEndTimeData.StructData.NativeFieldInfoPtr_StartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, nameof (StartHour));
        StartEndTimeData.StructData.NativeFieldInfoPtr_StartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, nameof (StartMinute));
        StartEndTimeData.StructData.NativeFieldInfoPtr_EndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, nameof (EndHour));
        StartEndTimeData.StructData.NativeFieldInfoPtr_EndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, nameof (EndMinute));
        StartEndTimeData.StructData.NativeMethodInfoPtr_get_StartTimeInMinutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666931);
        StartEndTimeData.StructData.NativeMethodInfoPtr_get_EndTimeInMinutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666932);
        StartEndTimeData.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666933);
        StartEndTimeData.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666934);
        StartEndTimeData.StructData.NativeMethodInfoPtr_IsWithinSpan_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666935);
        StartEndTimeData.StructData.NativeMethodInfoPtr_GetStartTimeFormatted_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666936);
        StartEndTimeData.StructData.NativeMethodInfoPtr_GetEndTimeFormatted_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, 100666937);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartEndTimeData.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
