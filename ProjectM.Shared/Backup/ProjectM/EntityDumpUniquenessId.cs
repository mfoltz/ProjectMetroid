// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityDumpUniquenessId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityDumpUniquenessId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryUniquenessId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_EntityDumpUniquenessId_PrimaryType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityDumpUniquenessId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public EntityDumpUniquenessId.PrimaryType Type;
    [FieldOffset(4)]
    public int SecondaryUniquenessId;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 258314, RefRangeEnd = 258319, XrefRangeStart = 258314, XrefRangeEnd = 258319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityDumpUniquenessId Create(
      EntityDumpUniquenessId.PrimaryType type,
      int secondaryUniquenessId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryUniquenessId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDumpUniquenessId.NativeMethodInfoPtr_Create_Public_Static_EntityDumpUniquenessId_PrimaryType_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityDumpUniquenessId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(EntityDumpUniquenessId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDumpUniquenessId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityDumpUniquenessId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733298, XrefRangeEnd = 733301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDumpUniquenessId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDumpUniquenessId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityDumpUniquenessId()
    {
      Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityDumpUniquenessId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr);
      EntityDumpUniquenessId.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, nameof (Type));
      EntityDumpUniquenessId.NativeFieldInfoPtr_SecondaryUniquenessId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, nameof (SecondaryUniquenessId));
      EntityDumpUniquenessId.NativeMethodInfoPtr_Create_Public_Static_EntityDumpUniquenessId_PrimaryType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, 100664803);
      EntityDumpUniquenessId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityDumpUniquenessId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, 100664804);
      EntityDumpUniquenessId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, 100664805);
      EntityDumpUniquenessId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, 100664806);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityDumpUniquenessId>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum PrimaryType
    {
      UniquenessDisabled,
      BoundsMinMax,
    }
  }
}
