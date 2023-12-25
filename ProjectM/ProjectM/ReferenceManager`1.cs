// Decompiled with JetBrains decompiler
// Type: ProjectM.ReferenceManager`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  public struct ReferenceManager<TRefKey>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveReferenceHashSet;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveReferenceList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReferencesUsedThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReferenceCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveReferenceTokens;
    private static readonly System.IntPtr NativeFieldInfoPtr__UniqueTokenCounter;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClaimToken_Public_ReferenceToken_1_TRefKey_TRefKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseToken_Public_Boolean_ReferenceToken_1_TRefKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_TRefKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAndGetReadyToUnload_Public_Void_NativeList_1_TRefKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStateCopy_Public_Void_NativeList_1_TRefKey_NativeList_1_ReferenceToken_1_TRefKey_0;
    public NativeHashSet<TRefKey> _ActiveReferenceHashSet;
    public NativeList<TRefKey> _ActiveReferenceList;
    public NativeHashSet<TRefKey> _ReferencesUsedThisFrame;
    public NativeHashMap<TRefKey, int> _ReferenceCounter;
    public NativeHashSet<ReferenceToken<TRefKey>> _ActiveReferenceTokens;
    public NativeReference<int> _UniqueTokenCounter;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073850, RefRangeEnd = 1073851, XrefRangeStart = 1073837, XrefRangeEnd = 1073850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReferenceManager(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073864, RefRangeEnd = 1073865, XrefRangeStart = 1073851, XrefRangeEnd = 1073864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073885, RefRangeEnd = 1073886, XrefRangeStart = 1073865, XrefRangeEnd = 1073885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReferenceToken<TRefKey> ClaimToken(TRefKey reference)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TRefKey& local1;
      if (!typeof (TRefKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TRefKey> local2 = (object) reference;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TRefKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TRefKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref reference;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_ClaimToken_Public_ReferenceToken_1_TRefKey_TRefKey_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ReferenceToken<TRefKey>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073896, RefRangeEnd = 1073897, XrefRangeStart = 1073886, XrefRangeEnd = 1073896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ReleaseToken(ReferenceToken<TRefKey> token)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) token));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_ReleaseToken_Public_Boolean_ReferenceToken_1_TRefKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073903, RefRangeEnd = 1073906, XrefRangeStart = 1073897, XrefRangeEnd = 1073903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MarkUsedThisFrame(TRefKey reference)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TRefKey& local1;
      if (!typeof (TRefKey).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TRefKey> local2 = (object) reference;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TRefKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TRefKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref reference;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_TRefKey_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073922, RefRangeEnd = 1073923, XrefRangeStart = 1073906, XrefRangeEnd = 1073922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAndGetReadyToUnload(NativeList<TRefKey> out_ToUnload)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &out_ToUnload;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_UpdateAndGetReadyToUnload_Public_Void_NativeList_1_TRefKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073935, RefRangeEnd = 1073936, XrefRangeStart = 1073923, XrefRangeEnd = 1073935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetStateCopy(
      NativeList<TRefKey> activeReferences,
      NativeList<ReferenceToken<TRefKey>> activeTokens)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &activeReferences;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeTokens;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReferenceManager<TRefKey>.NativeMethodInfoPtr_GetStateCopy_Public_Void_NativeList_1_TRefKey_NativeList_1_ReferenceToken_1_TRefKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReferenceManager()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "ReferenceManager`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRefKey>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr);
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__ActiveReferenceHashSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_ActiveReferenceHashSet));
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__ActiveReferenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_ActiveReferenceList));
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__ReferencesUsedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_ReferencesUsedThisFrame));
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__ReferenceCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_ReferenceCounter));
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__ActiveReferenceTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_ActiveReferenceTokens));
      ReferenceManager<TRefKey>.NativeFieldInfoPtr__UniqueTokenCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, nameof (_UniqueTokenCounter));
      ReferenceManager<TRefKey>.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684609);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684610);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_ClaimToken_Public_ReferenceToken_1_TRefKey_TRefKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684611);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_ReleaseToken_Public_Boolean_ReferenceToken_1_TRefKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684612);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_TRefKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684613);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_UpdateAndGetReadyToUnload_Public_Void_NativeList_1_TRefKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684614);
      ReferenceManager<TRefKey>.NativeMethodInfoPtr_GetStateCopy_Public_Void_NativeList_1_TRefKey_NativeList_1_ReferenceToken_1_TRefKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, 100684615);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReferenceManager<TRefKey>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
