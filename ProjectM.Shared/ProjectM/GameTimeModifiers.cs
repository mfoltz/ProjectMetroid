// Decompiled with JetBrains decompiler
// Type: ProjectM.GameTimeModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GameTimeModifiers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DayDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayStartHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayStartMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayEndHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayEndMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonBuff;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758653, RefRangeEnd = 758654, XrefRangeStart = 758651, XrefRangeEnd = 758653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameTimeModifiers.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameTimeModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameTimeModifiers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameTimeModifiers()
    {
      Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameTimeModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr);
      GameTimeModifiers.NativeFieldInfoPtr_DayDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (DayDurationInSeconds));
      GameTimeModifiers.NativeFieldInfoPtr_DayStartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (DayStartHour));
      GameTimeModifiers.NativeFieldInfoPtr_DayStartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (DayStartMinute));
      GameTimeModifiers.NativeFieldInfoPtr_DayEndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (DayEndHour));
      GameTimeModifiers.NativeFieldInfoPtr_DayEndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (DayEndMinute));
      GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (BloodMoonFrequency_Min));
      GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (BloodMoonFrequency_Max));
      GameTimeModifiers.NativeFieldInfoPtr_BloodMoonBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (BloodMoonBuff));
      GameTimeModifiers.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, 100666938);
      GameTimeModifiers.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, 100666939);
      GameTimeModifiers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, 100666940);
    }

    public GameTimeModifiers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DayDurationInSeconds
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayDurationInSeconds));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayDurationInSeconds)) = value;
      }
    }

    public unsafe byte DayStartHour
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayStartHour));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayStartHour)) = value;
      }
    }

    public unsafe byte DayStartMinute
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayStartMinute));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayStartMinute)) = value;
      }
    }

    public unsafe byte DayEndHour
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayEndHour));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayEndHour)) = value;
      }
    }

    public unsafe byte DayEndMinute
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayEndMinute));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_DayEndMinute)) = value;
      }
    }

    public unsafe byte BloodMoonFrequency_Min
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Min));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Min)) = value;
      }
    }

    public unsafe byte BloodMoonFrequency_Max
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Max));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonFrequency_Max)) = value;
      }
    }

    public unsafe float BloodMoonBuff
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonBuff));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameTimeModifiers.NativeFieldInfoPtr_BloodMoonBuff)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DayDurationInSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Min;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Max;
      private static readonly System.IntPtr NativeFieldInfoPtr_DayStartHour;
      private static readonly System.IntPtr NativeFieldInfoPtr_DayStartMinute;
      private static readonly System.IntPtr NativeFieldInfoPtr_DayEndHour;
      private static readonly System.IntPtr NativeFieldInfoPtr_DayEndMinute;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      [FieldOffset(0)]
      public half DayDurationInSeconds;
      [FieldOffset(2)]
      public half BloodMoonBuff;
      [FieldOffset(4)]
      public byte BloodMoonFrequency_Min;
      [FieldOffset(5)]
      public byte BloodMoonFrequency_Max;
      [FieldOffset(6)]
      public byte DayStartHour;
      [FieldOffset(7)]
      public byte DayStartMinute;
      [FieldOffset(8)]
      public byte DayEndHour;
      [FieldOffset(9)]
      public byte DayEndMinute;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758629, RefRangeEnd = 758630, XrefRangeStart = 758618, XrefRangeEnd = 758629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        GameTimeModifiers.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758641, RefRangeEnd = 758642, XrefRangeStart = 758630, XrefRangeEnd = 758641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe GameTimeModifiers.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GameTimeModifiers.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758650, RefRangeEnd = 758651, XrefRangeStart = 758642, XrefRangeEnd = 758650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameTimeModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameTimeModifiers>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr);
        GameTimeModifiers.StructData.NativeFieldInfoPtr_DayDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (DayDurationInSeconds));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_BloodMoonBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (BloodMoonBuff));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_BloodMoonFrequency_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (BloodMoonFrequency_Min));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_BloodMoonFrequency_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (BloodMoonFrequency_Max));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_DayStartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (DayStartHour));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_DayStartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (DayStartMinute));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_DayEndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (DayEndHour));
        GameTimeModifiers.StructData.NativeFieldInfoPtr_DayEndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, nameof (DayEndMinute));
        GameTimeModifiers.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, 100666941);
        GameTimeModifiers.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, 100666942);
        GameTimeModifiers.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, 100666943);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameTimeModifiers.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
