// Decompiled with JetBrains decompiler
// Type: ProjectM.UserCastleLimit
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
  public class UserCastleLimit : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_Castles;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_StructData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe UserCastleLimit.StructData Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserCastleLimit.NativeMethodInfoPtr_Convert_Public_StructData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserCastleLimit.StructData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserCastleLimit()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserCastleLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserCastleLimit()
    {
      Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UserCastleLimit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr);
      UserCastleLimit.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr, nameof (Level));
      UserCastleLimit.NativeFieldInfoPtr_Castles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr, nameof (Castles));
      UserCastleLimit.NativeMethodInfoPtr_Convert_Public_StructData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr, 100666981);
      UserCastleLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr, 100666982);
    }

    public UserCastleLimit(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe byte Level
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserCastleLimit.NativeFieldInfoPtr_Level));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserCastleLimit.NativeFieldInfoPtr_Level)) = value;
      }
    }

    public unsafe byte Castles
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserCastleLimit.NativeFieldInfoPtr_Castles));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserCastleLimit.NativeFieldInfoPtr_Castles)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StructData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Level;
      private static readonly System.IntPtr NativeFieldInfoPtr_Castles;
      [FieldOffset(0)]
      public byte Level;
      [FieldOffset(1)]
      public byte Castles;

      static StructData()
      {
        Il2CppClassPointerStore<UserCastleLimit.StructData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserCastleLimit>.NativeClassPtr, nameof (StructData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserCastleLimit.StructData>.NativeClassPtr);
        UserCastleLimit.StructData.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCastleLimit.StructData>.NativeClassPtr, nameof (Level));
        UserCastleLimit.StructData.NativeFieldInfoPtr_Castles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserCastleLimit.StructData>.NativeClassPtr, nameof (Castles));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserCastleLimit.StructData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
