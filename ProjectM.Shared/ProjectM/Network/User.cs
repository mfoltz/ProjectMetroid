// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.User
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct User
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generation;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferPositionBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFullyAckedFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeLastConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeLastInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserContent;
    private static readonly System.IntPtr NativeFieldInfoPtr_CryptSpawnIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlackEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AFKKickWarningSent;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBot;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsConnected;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_User_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_User_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public int Index;
    [FieldOffset(4)]
    public int Generation;
    [FieldOffset(8)]
    public int BufferPositionBits;
    [FieldOffset(12)]
    public int LastFullyAckedFrame;
    [FieldOffset(16)]
    public NetworkedEntity LocalCharacter;
    [FieldOffset(28)]
    public NetworkedEntity ClanEntity;
    [FieldOffset(40)]
    public ulong PlatformId;
    [FieldOffset(48)]
    public long TimeLastConnected;
    [FieldOffset(56)]
    public long TimeLastInput;
    [FieldOffset(64)]
    public FixedString64 CharacterName;
    [FieldOffset(128)]
    public UserContentFlags UserContent;
    [FieldOffset(132)]
    public Nullable_Unboxed<int> CryptSpawnIndex;
    [FieldOffset(140)]
    public Entity FadeToBlackEntity;
    [FieldOffset(148)]
    public bool AFKKickWarningSent;
    [FieldOffset(149)]
    public bool IsBot;
    [FieldOffset(150)]
    public bool IsAdmin;
    [FieldOffset(151)]
    public bool IsConnected;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785429, XrefRangeEnd = 785475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    public static unsafe User Empty
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_get_Empty_Public_Static_get_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(User*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe bool Equals(User other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_Equals_Public_Boolean_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785475, RefRangeEnd = 785476, XrefRangeStart = 785475, XrefRangeEnd = 785475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(User user1, User user2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &user1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_User_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 785476, RefRangeEnd = 785482, XrefRangeStart = 785476, XrefRangeEnd = 785476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(User user1, User user2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &user1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_User_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785482, XrefRangeEnd = 785485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785485, XrefRangeEnd = 785487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(User.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static User()
    {
      Il2CppClassPointerStore<User>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (User));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<User>.NativeClassPtr);
      User.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (Index));
      User.NativeFieldInfoPtr_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (Generation));
      User.NativeFieldInfoPtr_BufferPositionBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (BufferPositionBits));
      User.NativeFieldInfoPtr_LastFullyAckedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (LastFullyAckedFrame));
      User.NativeFieldInfoPtr_LocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (LocalCharacter));
      User.NativeFieldInfoPtr_ClanEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (ClanEntity));
      User.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (PlatformId));
      User.NativeFieldInfoPtr_TimeLastConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (TimeLastConnected));
      User.NativeFieldInfoPtr_TimeLastInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (TimeLastInput));
      User.NativeFieldInfoPtr_CharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (CharacterName));
      User.NativeFieldInfoPtr_UserContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (UserContent));
      User.NativeFieldInfoPtr_CryptSpawnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (CryptSpawnIndex));
      User.NativeFieldInfoPtr_FadeToBlackEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (FadeToBlackEntity));
      User.NativeFieldInfoPtr_AFKKickWarningSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (AFKKickWarningSent));
      User.NativeFieldInfoPtr_IsBot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (IsBot));
      User.NativeFieldInfoPtr_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (IsAdmin));
      User.NativeFieldInfoPtr_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, nameof (IsConnected));
      User.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669217);
      User.NativeMethodInfoPtr_get_Empty_Public_Static_get_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669218);
      User.NativeMethodInfoPtr_Equals_Public_Boolean_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669219);
      User.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_User_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669220);
      User.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_User_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669221);
      User.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669222);
      User.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User>.NativeClassPtr, 100669223);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<User>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
