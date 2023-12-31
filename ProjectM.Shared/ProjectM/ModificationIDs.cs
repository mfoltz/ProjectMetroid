// Decompiled with JetBrains decompiler
// Type: ProjectM.ModificationIDs
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModificationIDs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationIdGenerator;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModifiableIdGenerator;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ModificationIDs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewModificationId_Public_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewModifiableId_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGeneratorState_Public_Void_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGeneratorState_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public BurstableIdGenerator _ModificationIdGenerator;
    [FieldOffset(8)]
    public BurstableIdGenerator _ModifiableIdGenerator;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746828, XrefRangeEnd = 746830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationIDs Create()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_Create_Public_Static_ModificationIDs_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationIDs*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 746831, RefRangeEnd = 746833, XrefRangeStart = 746830, XrefRangeEnd = 746831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationId NewModificationId()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_NewModificationId_Public_ModificationId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746833, XrefRangeEnd = 746834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int NewModifiableId()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_NewModifiableId_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 746836, RefRangeEnd = 746837, XrefRangeStart = 746834, XrefRangeEnd = 746836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetGeneratorState(out int modificationIdState, out int modifiableIdState)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref modificationIdState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifiableIdState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_GetGeneratorState_Public_Void_byref_Int32_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746837, XrefRangeEnd = 746839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeGeneratorState(
      int modificationIdGeneratorState,
      int modifiableIdGenerator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modificationIdGeneratorState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modifiableIdGenerator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_InitializeGeneratorState_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746839, XrefRangeEnd = 746840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationIDs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModificationIDs()
    {
      Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModificationIDs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr);
      ModificationIDs.NativeFieldInfoPtr__ModificationIdGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, nameof (_ModificationIdGenerator));
      ModificationIDs.NativeFieldInfoPtr__ModifiableIdGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, nameof (_ModifiableIdGenerator));
      ModificationIDs.NativeMethodInfoPtr_Create_Public_Static_ModificationIDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665716);
      ModificationIDs.NativeMethodInfoPtr_NewModificationId_Public_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665717);
      ModificationIDs.NativeMethodInfoPtr_NewModifiableId_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665718);
      ModificationIDs.NativeMethodInfoPtr_GetGeneratorState_Public_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665719);
      ModificationIDs.NativeMethodInfoPtr_InitializeGeneratorState_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665720);
      ModificationIDs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, 100665721);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModificationIDs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
