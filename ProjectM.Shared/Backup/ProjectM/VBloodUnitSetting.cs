// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodUnitSetting
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class VBloodUnitSetting : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitId;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultUnlocked;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758664, RefRangeEnd = 758665, XrefRangeStart = 758664, XrefRangeEnd = 758664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodUnitSetting.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(VBloodUnitSetting.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 758510, RefRangeEnd = 758618, XrefRangeStart = 758510, XrefRangeEnd = 758618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.NativeMethodInfoPtr_Clone_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodUnitSetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodUnitSetting()
    {
      Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VBloodUnitSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr);
      VBloodUnitSetting.NativeFieldInfoPtr_UnitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, nameof (UnitId));
      VBloodUnitSetting.NativeFieldInfoPtr_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, nameof (UnitLevel));
      VBloodUnitSetting.NativeFieldInfoPtr_DefaultUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, nameof (DefaultUnlocked));
      VBloodUnitSetting.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, 100666944);
      VBloodUnitSetting.NativeMethodInfoPtr_Clone_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, 100666945);
      VBloodUnitSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, 100666946);
    }

    public VBloodUnitSetting(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int UnitId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_UnitId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_UnitId)) = value;
      }
    }

    public unsafe byte UnitLevel
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_UnitLevel));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_UnitLevel)) = value;
      }
    }

    public unsafe bool DefaultUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_DefaultUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitSetting.NativeFieldInfoPtr_DefaultUnlocked)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitId;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_DefaultUnlocked;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ClampValues_Public_Void_0;
      [FieldOffset(0)]
      public int UnitId;
      [FieldOffset(4)]
      public byte UnitLevel;
      [FieldOffset(5)]
      public bool DefaultUnlocked;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 758657, RefRangeEnd = 758658, XrefRangeStart = 758654, XrefRangeEnd = 758657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Serialize(
        [In] ref VBloodUnitSetting.StructData settings,
        ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 758661, RefRangeEnd = 758664, XrefRangeStart = 758658, XrefRangeEnd = 758661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe VBloodUnitSetting.StructData Deserialize(ref NetBufferIn netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(VBloodUnitSetting.StructData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void ClampValues()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodUnitSetting.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StructData()
      {
        Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodUnitSetting>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr);
        VBloodUnitSetting.StructData.NativeFieldInfoPtr_UnitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, nameof (UnitId));
        VBloodUnitSetting.StructData.NativeFieldInfoPtr_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, nameof (UnitLevel));
        VBloodUnitSetting.StructData.NativeFieldInfoPtr_DefaultUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, nameof (DefaultUnlocked));
        VBloodUnitSetting.StructData.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_StructData_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, 100666947);
        VBloodUnitSetting.StructData.NativeMethodInfoPtr_Deserialize_Public_Static_StructData_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, 100666948);
        VBloodUnitSetting.StructData.NativeMethodInfoPtr_ClampValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, 100666949);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodUnitSetting.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
