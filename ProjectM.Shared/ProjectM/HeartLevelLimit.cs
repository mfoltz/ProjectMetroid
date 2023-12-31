// Decompiled with JetBrains decompiler
// Type: ProjectM.HeartLevelLimit
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class HeartLevelLimit : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildLimits;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultHeightLimit;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 758949, RefRangeEnd = 758954, XrefRangeStart = 758949, XrefRangeEnd = 758949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeartLevelLimit.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeartLevelLimit.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HeartLevelLimit.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeartLevelLimit.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeartLevelLimit()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeartLevelLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeartLevelLimit()
    {
      Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeartLevelLimit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr);
      HeartLevelLimit.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (Level));
      HeartLevelLimit.NativeFieldInfoPtr_FloorLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (FloorLimit));
      HeartLevelLimit.NativeFieldInfoPtr_ServantLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (ServantLimit));
      HeartLevelLimit.NativeFieldInfoPtr_BuildLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (BuildLimits));
      HeartLevelLimit.NativeFieldInfoPtr_HeightLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (HeightLimit));
      HeartLevelLimit.NativeFieldInfoPtr_DefaultHeightLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (DefaultHeightLimit));
      HeartLevelLimit.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, 100666978);
      HeartLevelLimit.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, 100666979);
      HeartLevelLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, 100666980);
    }

    public HeartLevelLimit(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe byte Level
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_Level));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_Level)) = value;
      }
    }

    public unsafe short FloorLimit
    {
      get
      {
        return *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_FloorLimit));
      }
      [param: In] set
      {
        *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_FloorLimit)) = value;
      }
    }

    public unsafe byte ServantLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_ServantLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_ServantLimit)) = value;
      }
    }

    public unsafe HeartBuildLimits BuildLimits
    {
      get
      {
        return *(HeartBuildLimits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_BuildLimits));
      }
      [param: In] set
      {
        *(HeartBuildLimits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_BuildLimits)) = value;
      }
    }

    public unsafe byte HeightLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_HeightLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLevelLimit.NativeFieldInfoPtr_HeightLimit)) = value;
      }
    }

    public static unsafe byte DefaultHeightLimit
    {
      get
      {
        byte defaultHeightLimit;
        IL2CPP.il2cpp_field_static_get_value(HeartLevelLimit.NativeFieldInfoPtr_DefaultHeightLimit, (void*) &defaultHeightLimit);
        return defaultHeightLimit;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeartLevelLimit.NativeFieldInfoPtr_DefaultHeightLimit, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Level;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorLimit;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantLimit;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuildLimits;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeightLimit;
      [FieldOffset(0)]
      public byte Level;
      [FieldOffset(2)]
      public short FloorLimit;
      [FieldOffset(4)]
      public byte ServantLimit;
      [FieldOffset(5)]
      public HeartBuildLimits BuildLimits;
      [FieldOffset(6)]
      public byte HeightLimit;

      static StructData()
      {
        Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeartLevelLimit>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr);
        HeartLevelLimit.StructData.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, nameof (Level));
        HeartLevelLimit.StructData.NativeFieldInfoPtr_FloorLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, nameof (FloorLimit));
        HeartLevelLimit.StructData.NativeFieldInfoPtr_ServantLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, nameof (ServantLimit));
        HeartLevelLimit.StructData.NativeFieldInfoPtr_BuildLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, nameof (BuildLimits));
        HeartLevelLimit.StructData.NativeFieldInfoPtr_HeightLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, nameof (HeightLimit));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeartLevelLimit.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
